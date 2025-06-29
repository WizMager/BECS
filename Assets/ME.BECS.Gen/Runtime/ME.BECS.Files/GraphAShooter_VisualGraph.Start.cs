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
    public static unsafe class GraphGraphAShooter_VisualGraphStart {
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnStart_0_1002_SystemsCodeGenerator_Burst(uint dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, safe_ptr<Unity.Jobs.JobHandle> dependencies
        ) {
            SystemContext systemContext = default;
            {
                systemContext = SystemContext.Create(dt, in world, dependencies[6]);
                ((ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)systems[1])->OnStart(ref systemContext);
                dependencies[7] = Batches.Apply(systemContext.dependsOn, world.state);
            }
            dependencies[4] = dependencies[7];
            dependsOn = dependencies[4];
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_1002_SystemsCodeGenerator(uint dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // AShooter-VisualGraph
            var systems = (System.IntPtr*)GraphGraphAShooter_VisualGraphInitialize.graphNodes1002_SystemsCodeGenerator.GetUnsafePtr();
            var dependencies = _makeArray<Unity.Jobs.JobHandle>(8, Constants.ALLOCATOR_TEMP, false);
            dependencies[1] = dependsOn;
            dependencies[2] = dependencies[1];
            dependencies[3] = dependencies[2];
            dependencies[5] = dependencies[3];
            dependencies[6] = dependencies[5];
            // BURST ENABLE CLOSE
            InnerMethodOnStart_0_1002_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, dependencies
            
            );
            
            dependsOn = dependencies[4];
            // Dependencies scheme:
            // * dependsOn                        => dep1002_0_0         START                            [ SKIPPED ]
            // * dep1002_0_0                      => dep1002_3_0         AShooter.Systems.CharacterInp... [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep1002_3_0                      => dep30_2_0           START                            [ SKIPPED ]
            // * dep30_2_0                        => dep30_4_0           ME.BECS.DestroyWithTicksSystem   [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep30_4_0                        => dep30_0_0           ME.BECS.DestroyWithLifetimeSy... [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * Batches.Apply                    :  dep30_0_0 => dep30_1_0                               [  SYNC   ]
            // * dep30_1_0                        => dep30_1_0           ME.BECS.Transforms.TransformW... [  BURST  ]
            // * EXIT dep1002_2_0 = dep30_1_0;
            // * EXIT dependsOn = dep1002_2_0;
            // * dependencies[4]                  => dependsOn       
        }
    }
     
}
