namespace ME.BECS {
    using BURST = Unity.Burst.BurstCompileAttribute;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine.Scripting;
    using Unity.Burst;
    using Unity.Jobs.LowLevel.Unsafe;
    using ME.BECS.Jobs;
    using static Cuts;
    using s = System.Collections.Generic;
    public static unsafe class GraphGraphAShooter_FeaturesGraphDrawGizmos {
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_1001_SystemsCodeGenerator(uint dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // AShooter-FeaturesGraph
            var systems = (System.IntPtr*)GraphGraphAShooter_FeaturesGraphInitialize.graphNodes1001_SystemsCodeGenerator.GetUnsafePtr();
        }
    }
     
}
