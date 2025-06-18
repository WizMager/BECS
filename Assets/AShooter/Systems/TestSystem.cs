using AShooter.Aspects;
using AShooter.Components;
using ME.BECS;
using ME.BECS.Views;

namespace AShooter.Systems
{
    public struct TestSystem : IStart,IUpdate
    {
        public Config PlayerCharacterConfig;
        
        public void OnUpdate(ref SystemContext context)
        {
            
        }

        public void OnStart(ref SystemContext context)
        {
            var cameraAspect = CameraUtils.CreateCamera(context.world);
            
            var playerEnt = Ent.New();
            PlayerCharacterConfig.Apply(playerEnt);
            playerEnt.Set<PlayerCharacterAspect>();
        }
    }
}