using ME.BECS;

namespace AShooter
{
    public class ViewInitializer : WorldInitializer
    {
        public static ViewInitializer Instance;
        

        protected override void Awake()
        {
            Instance = this;
            
            base.Awake();
        }

        protected override void DoWorldAwake()
        {
            world.parent = NetworkInitializer.Instance.world;
            
            base.DoWorldAwake();
        }
    }
}