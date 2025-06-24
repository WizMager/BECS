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
    public static unsafe class GraphGraphAShooter_FeaturesGraphInitialize {
        public static NativeArray<System.IntPtr> graphNodes1001_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_1001_SystemsCodeGenerator() {
            // AShooter-FeaturesGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes1001_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(6, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithLifetimeSystem>.sizeInt, TAlign<ME.BECS.DestroyWithLifetimeSystem>.alignInt);
                *(ME.BECS.DestroyWithLifetimeSystem*)item = (ME.BECS.DestroyWithLifetimeSystem)((ME.BECS.FeaturesGraph.Nodes.SystemNode)ObjectReferenceRegistry.GetObjectBySourceId<ME.BECS.FeaturesGraph.SystemsGraph>(6).nodes[0]).system;
                TSystemGraph.Register<ME.BECS.DestroyWithLifetimeSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.sizeInt, TAlign<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.alignInt);
                *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)item = (ME.BECS.Transforms.TransformWorldMatrixUpdateSystem)((ME.BECS.FeaturesGraph.Nodes.SystemNode)ObjectReferenceRegistry.GetObjectBySourceId<ME.BECS.FeaturesGraph.SystemsGraph>(6).nodes[1]).system;
                TSystemGraph.Register<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithTicksSystem>.sizeInt, TAlign<ME.BECS.DestroyWithTicksSystem>.alignInt);
                *(ME.BECS.DestroyWithTicksSystem*)item = (ME.BECS.DestroyWithTicksSystem)((ME.BECS.FeaturesGraph.Nodes.SystemNode)ObjectReferenceRegistry.GetObjectBySourceId<ME.BECS.FeaturesGraph.SystemsGraph>(6).nodes[4]).system;
                TSystemGraph.Register<ME.BECS.DestroyWithTicksSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Players.PlayersSystem>.sizeInt, TAlign<ME.BECS.Players.PlayersSystem>.alignInt);
                *(ME.BECS.Players.PlayersSystem*)item = (ME.BECS.Players.PlayersSystem)((ME.BECS.FeaturesGraph.Nodes.SystemNode)ObjectReferenceRegistry.GetObjectBySourceId<ME.BECS.FeaturesGraph.SystemsGraph>(31).nodes[3]).system;
                TSystemGraph.Register<ME.BECS.Players.PlayersSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[3] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<AShooter.Systems.InitializeSystem>.sizeInt, TAlign<AShooter.Systems.InitializeSystem>.alignInt);
                *(AShooter.Systems.InitializeSystem*)item = (AShooter.Systems.InitializeSystem)((ME.BECS.FeaturesGraph.Nodes.SystemNode)ObjectReferenceRegistry.GetObjectBySourceId<ME.BECS.FeaturesGraph.SystemsGraph>(31).nodes[4]).system;
                TSystemGraph.Register<AShooter.Systems.InitializeSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[4] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<AShooter.Systems.MovementSystem>.sizeInt, TAlign<AShooter.Systems.MovementSystem>.alignInt);
                *(AShooter.Systems.MovementSystem*)item = (AShooter.Systems.MovementSystem)((ME.BECS.FeaturesGraph.Nodes.SystemNode)ObjectReferenceRegistry.GetObjectBySourceId<ME.BECS.FeaturesGraph.SystemsGraph>(31).nodes[5]).system;
                TSystemGraph.Register<AShooter.Systems.MovementSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[5] = (System.IntPtr)item;
            }
            // Injections:
            JobInject<AShooter.Systems.MovementSystem.MoveJob>.RegisterDeltaTime(0, 1);
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_1001_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes1001_SystemsCodeGenerator[index];
        }
    }
     
}
