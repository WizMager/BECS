using AShooter.Components;
using ME.BECS;

namespace AShooter.Aspects
{
    public struct PlayerCharacterAspect : IAspect
    {
        public Ent ent { get; set; }

        [QueryWith]
        public AspectDataPtr<PlayerCharacterComponent> PlayerCharComponent;

        public readonly ref PlayerCharacterComponent PlayerTag => ref PlayerCharComponent.Get(ent.id, ent.gen);
        public readonly PlayerCharacterComponent ReadPlayerTag => PlayerCharComponent.Read(ent.id, ent.gen);
    }
}