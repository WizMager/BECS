using AOT;
using AShooter.Components;
using ME.BECS;
using ME.BECS.FixedPoint;
using ME.BECS.Jobs;
using ME.BECS.Network;
using ME.BECS.Network.Markers;
using UnityEngine;
using IJobForComponents = ME.BECS.Jobs.IJobForComponents;

namespace AShooter.Systems
{
    public struct CharacterInputSystem : IUpdate
    {
        private Vector2 _previousMoveInput;

        
        public void OnUpdate(ref SystemContext context)
        {
            var horizontal = Input.GetAxisRaw("Horizontal");
            var vertical = Input.GetAxisRaw("Vertical");
            var moveInput = new Vector2(horizontal, vertical);

            if (moveInput != _previousMoveInput)
            {
                var normalizedMoveInput = math.normalizesafe((float2)moveInput);
            
                context.world.parent.SendNetworkEvent(new MoveInputData
                {
                    InputData = normalizedMoveInput
                }, ApplyMoveInput);
            
                _previousMoveInput = moveInput;
            }
        }

        [NetworkMethod]
        [MonoPInvokeCallback(typeof(NetworkMethodDelegate))]
        public static void ApplyMoveInput(in InputData data, ref SystemContext context)
        {
            var inputData = data.GetData<MoveInputData>();

            context.Query().AsParallel().With<PlayerCharacterComponent>().Schedule(new MoveInputJob
            {
                InputData = inputData.InputData
            }).AddDependency(ref context);
        }
        
        public struct MoveInputJob : IJobForComponents
        {
            public float2 InputData;
            
            public void Execute(in JobInfo jobInfo, in Ent ent)
            {
                ent.Set(new MoveInputComponent
                {
                    MoveInput = InputData
                });
            }
        }
        
        public struct MoveInputData : IPackageData
        {
            public float2 InputData;
            
            public void Serialize(ref StreamBufferWriter writer)
            {
                writer.Write(InputData);
            }

            public void Deserialize(ref StreamBufferReader reader)
            {
                reader.Read(ref InputData);
            }
        }
    }
}