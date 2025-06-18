using ME.BECS;
using ME.BECS.Players;

namespace AShooter.Aspects
{
    public struct PlayerAspect : IAspect
    {
        public Ent ent { get; set; }

        [QueryWith]
        public AspectDataPtr<PlayerComponent> PlayerComponent;
    }
}