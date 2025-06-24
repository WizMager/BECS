using AShooter.Components;
using ME.BECS;

namespace AShooter.Aspects
{
    public struct PlayerCharacterAspect : IAspect
    {
        public Ent ent { get; set; }
        
        public AspectDataPtr<MoveSpeedComponent> MoveSpeedComponent;
        [QueryWith]
        public AspectDataPtr<PlayerCharacterComponent> PlayerCharacterComponent;

        public readonly ref MoveSpeedComponent PlayerMoveSpeed => ref MoveSpeedComponent.Get(ent.id, ent.gen);
        public readonly float ReadMoveSpeed => MoveSpeedComponent.Read(ent.id, ent.gen).Value;
    }
}