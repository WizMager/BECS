using AShooter.Aspects;
using AShooter.Components;
using ME.BECS;
using ME.BECS.FixedPoint;
using ME.BECS.Jobs;
using ME.BECS.Transforms;
using ME.BECS.Views;
using float3 = Unity.Mathematics.float3;

namespace AShooter.Systems
{
    public struct TestSystem : IStart,IUpdate
    {
        public Config PlayerCharacterConfig;
        
        public void OnUpdate(ref SystemContext context)
        {
            context.Query().AsParallel().With<PlayerCharacterComponent>()
                .Schedule<MoveJob, TransformAspect, MoveInputComponent>()
                .AddDependency(ref context);
        }

        public void OnStart(ref SystemContext context)
        {
            context.dependsOn.Complete();
            
            var cameraAspect = CameraUtils.CreateCamera(context.world);
            
            var playerEnt = Ent.New();
            PlayerCharacterConfig.Apply(playerEnt);
            playerEnt.Set<PlayerCharacterAspect>();
        }
        
        public struct MoveJob : IJobFor1Aspects1Components<TransformAspect, MoveInputComponent>
        {
            [InjectDeltaTime] public sfloat DeltaTime;
            public sfloat Speed;

            public void Execute(in JobInfo jobInfo, in Ent ent, ref TransformAspect transformAspect, ref MoveInputComponent moveInput)
            {
                var moveDirection = new float3(moveInput.MoveInput.x, 0, moveInput.MoveInput.y);
                transformAspect.position += moveDirection * (float)Speed * (float)DeltaTime;
            }
        }
    }
}