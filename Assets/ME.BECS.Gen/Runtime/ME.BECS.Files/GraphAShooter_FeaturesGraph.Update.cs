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
    public static unsafe class GraphGraphAShooter_FeaturesGraphUpdate {
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_1001_SystemsCodeGenerator_Burst(uint dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, safe_ptr<Unity.Jobs.JobHandle> dependencies
        ) {
            SystemContext systemContext = default;
            {
                systemContext = SystemContext.Create(dt, in world, dependencies[3]);
                ((AShooter.Systems.MovementSystem*)systems[5])->OnUpdate(ref systemContext);
                dependencies[4] = Batches.Apply(systemContext.dependsOn, world.state);
            }
            dependencies[5] = dependencies[4];
            {
                systemContext = SystemContext.Create(dt, in world, dependencies[5]);
                ((ME.BECS.DestroyWithTicksSystem*)systems[2])->OnUpdate(ref systemContext);
                dependencies[7] = Batches.Apply(systemContext.dependsOn, world.state);
            }
            {
                systemContext = SystemContext.Create(dt, in world, dependencies[7]);
                ((ME.BECS.DestroyWithLifetimeSystem*)systems[0])->OnUpdate(ref systemContext);
                dependencies[8] = Batches.Apply(systemContext.dependsOn, world.state);
            }
            {
                systemContext = SystemContext.Create(dt, in world, dependencies[8]);
                ((ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)systems[1])->OnUpdate(ref systemContext);
                dependencies[9] = Batches.Apply(systemContext.dependsOn, world.state);
            }
            dependencies[6] = dependencies[9];
            dependsOn = dependencies[6];
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_1001_SystemsCodeGenerator(uint dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // AShooter-FeaturesGraph
            var systems = (System.IntPtr*)GraphGraphAShooter_FeaturesGraphInitialize.graphNodes1001_SystemsCodeGenerator.GetUnsafePtr();
            var dependencies = _makeArray<Unity.Jobs.JobHandle>(10, Constants.ALLOCATOR_TEMP, false);
            dependencies[1] = dependsOn;
            dependencies[2] = dependencies[1];
            dependencies[3] = dependencies[2];
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_1001_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, dependencies
            
            );
            
            dependsOn = dependencies[6];
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0_0         START                            [ SKIPPED ]
            // * dep1001_0_0                      => dep1001_3_0         ME.BECS.Players.PlayersSystem    [NOT BURST] - Method ME.BECS.IUpdate was not found. Node skipped.
            // * dep1001_3_0                      => dep1001_4_0         AShooter.Systems.InitializeSy... [NOT BURST] - Method ME.BECS.IUpdate was not found. Node skipped.
            // * Batches.Apply                    :  dep1001_4_0 => dep1001_5_0                           [  SYNC   ]
            // * dep1001_5_0                      => dep1001_5_0         AShooter.Systems.MovementSystem  [  BURST  ]
            // * dep1001_5_0                      => dep30_2_0           START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep30_2_0 => dep30_4_0                               [  SYNC   ]
            // * dep30_4_0                        => dep30_4_0           ME.BECS.DestroyWithTicksSystem   [  BURST  ]
            // * Batches.Apply                    :  dep30_4_0 => dep30_0_0                               [  SYNC   ]
            // * dep30_0_0                        => dep30_0_0           ME.BECS.DestroyWithLifetimeSy... [  BURST  ]
            // * Batches.Apply                    :  dep30_0_0 => dep30_1_0                               [  SYNC   ]
            // * dep30_1_0                        => dep30_1_0           ME.BECS.Transforms.TransformW... [  BURST  ]
            // * EXIT dep1001_2_0 = dep30_1_0;
            // * EXIT dependsOn = dep1001_2_0;
            // * dependencies[6]                  => dependsOn       
        }
    }
     
}
