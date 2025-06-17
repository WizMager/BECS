using ME.BECS.Network;

namespace AShooter {
    
    public class NetworkInitializer : NetworkWorldInitializer
    {
        public static NetworkInitializer Instance;
        
        public static NetworkModule GetNetworkModule => Instance.networkModule;

        protected override void Awake()
        {
            Instance = this;
            
            base.Awake();
        }

        protected override void DoWorldAwake()
        {
            world.parent = Instance.world;
            
            base.DoWorldAwake();
        }
    }
    
}