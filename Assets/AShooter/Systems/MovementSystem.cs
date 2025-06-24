using AShooter.Components;
using ME.BECS;
using ME.BECS.Jobs;
using ME.BECS.Transforms;
using Unity.Burst;
using float3 = Unity.Mathematics.float3;

namespace AShooter.Systems
{
    [BurstCompile]
    public struct MovementSystem : IUpdate
    {
        public void OnUpdate(ref SystemContext context)
        {
            context.Query().AsParallel().With<PlayerCharacterComponent>()
                .Schedule<MoveJob, TransformAspect, MoveInputComponent>()
                .AddDependency(ref context);
        }
        
        public struct MoveJob : IJobFor1Aspects1Components<TransformAspect, MoveInputComponent>
        {
            [InjectDeltaTime] public sfloat DeltaTime;

            public void Execute(in JobInfo jobInfo, in Ent ent, ref TransformAspect transformAspect, ref MoveInputComponent moveInput)
            {
                var moveDirection = new float3(moveInput.MoveInput.x, 0, moveInput.MoveInput.y);
                transformAspect.position += moveDirection * ent.Get<MoveSpeedComponent>().Value * (float)DeltaTime;
            }
        }
    }
}