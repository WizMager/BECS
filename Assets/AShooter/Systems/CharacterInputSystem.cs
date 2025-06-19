using AOT;
using AShooter.Components;
using AShooter.Utils;
using ME.BECS;
using ME.BECS.FixedPoint;
using ME.BECS.Jobs;
using ME.BECS.Network;
using ME.BECS.Network.Markers;
using UnityEngine;
using IJobForComponents = ME.BECS.Jobs.IJobForComponents;

namespace AShooter.Systems
{
    public struct CharacterInputSystem : IStart, IUpdate, IDestroy
    {
        public ObjectReference<InputUtils> Input;

        private Vector2 _previousMoveInput;
        
        public void OnStart(ref SystemContext context)
        {
            _previousMoveInput = Vector2.zero;
            Input.Value.InputActions.Enable();
        }
        
        public void OnUpdate(ref SystemContext context)
        {
            var moveInput = Input.Value.InputActions.Player.Move.ReadValue<Vector2>();
            
            if (moveInput == _previousMoveInput)
                return;

            var normalizedMoveInput = math.normalizesafe((float2)moveInput);
            
            context.world.parent.SendNetworkEvent(new MoveInputData
            {
                InputData = normalizedMoveInput
            }, ApplyMoveInput);
            
            _previousMoveInput = moveInput;
        }

        public void OnDestroy(ref SystemContext context)
        {
            Input.Value.InputActions.Disable();
            Input.Value.InputActions.Dispose();
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
                    MoveInput = (Vector2)InputData
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