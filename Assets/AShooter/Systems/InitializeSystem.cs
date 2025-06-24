using AShooter.Components;
using ME.BECS;
using ME.BECS.Transforms;
using ME.BECS.Views;
using Unity.Mathematics;
using UnityEngine;

namespace AShooter.Systems
{
    public struct InitializeSystem : IStart
    {
        public Config PlayerCharacterConfig;
        public Config CameraConfig;
        
        public void OnStart(ref SystemContext context)
        {
            context.dependsOn.Complete();
            
            var cameraEnt = Ent.New(context);
            CreateCamera(ref cameraEnt);
            //CameraUtils.CreateCamera(camera,context.world);
            
            var playerEnt = Ent.New(context);
            CreatePlayerCharacter(ref playerEnt);
        }

        private void CreatePlayerCharacter(ref Ent playerEnt)
        {
            PlayerCharacterConfig.Apply(playerEnt);
            playerEnt.Set(new PlayerCharacterComponent());
            playerEnt.Set(new MoveSpeedComponent
            {
                Value = 5
            });
        }
        
        private void CreateCamera(ref Ent cameraEnt)
        {
            CameraConfig.Apply(cameraEnt);
        }
    }
}