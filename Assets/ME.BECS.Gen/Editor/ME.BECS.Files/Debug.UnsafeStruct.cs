namespace ME.BECS.Editor {
    using BURST = Unity.Burst.BurstCompileAttribute;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine.Scripting;
    using Unity.Burst;
    using Unity.Jobs.LowLevel.Unsafe;
    using ME.BECS.Jobs;
    using static Cuts;
    using s = System.Collections.Generic;
    using UnityEditor;
    public static unsafe class DebugJobsStructUnsafe {
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public struct JobDebugData1Unsafe { // AShooter.Systems.CharacterInputSystem+MoveInputJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public AShooter.Systems.CharacterInputSystem.MoveInputJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData2Unsafe { // ME.BECS.Attack.MoveToAttackerSystem+RemoveComebackAfterAttackComponentJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.RemoveComebackAfterAttackComponentJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData3Unsafe { // ME.BECS.Commands.CommandAttackCleanSystem+RemoveJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackCleanSystem.RemoveJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.UnitAttackCommandComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        
        public struct JobDebugData4Unsafe { // ME.BECS.Commands.CommandBuildUpdateSystem+CompleteJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.BuildingInProgress> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
        }
        
        public struct JobDebugData5Unsafe { // ME.BECS.Commands.CommandBuildUpdateSystem+UpdateProgressJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.BuildInProgress> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        
        public struct JobDebugData6Unsafe { // ME.BECS.DestroyWithLifetimeSystem+LifetimeJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithLifetimeSystem.LifetimeJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.DestroyWithLifetime> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        
        public struct JobDebugData7Unsafe { // ME.BECS.DestroyWithLifetimeSystem+LifetimeMsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithLifetimeSystem.LifetimeMsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.DestroyWithLifetimeMs> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        
        public struct JobDebugData8Unsafe { // ME.BECS.DestroyWithTicksSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithTicksSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.DestroyWithTicks> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        
        public struct JobDebugData9Unsafe { // ME.BECS.FogOfWar.ShadowCopySystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopySystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyRequiredRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        
        public struct JobDebugData10Unsafe { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdatePointsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        
        public struct JobDebugData11Unsafe { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdateRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        
        public struct JobDebugData12Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData13Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangePartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData14Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData15Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData16Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData17Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRectPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData18Unsafe { // ME.BECS.Pathfinding.BuildPathSystem+UpdatePathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.TargetComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        
        public struct JobDebugData19Unsafe { // ME.BECS.Pathfinding.UpdateGraphSystem+ResetPathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.TargetPathComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        
        public struct JobDebugData20Unsafe { // ME.BECS.Pathfinding.UpdateGraphSystem+UpdateGraphMaskJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.GraphMaskComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> ME_BECS_Pathfinding_GraphMaskRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent> ME_BECS_Pathfinding_IsGraphMaskDirtyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        
        public struct JobDebugData21Unsafe { // ME.BECS.Tests.Tests_Aspects+TestDestroyJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestTargetComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Tests.TestTargetComponent> ME_BECS_Tests_TestTargetComponent;
        }
        
        public struct JobDebugData22Unsafe { // ME.BECS.Tests.Tests_Queries_Static+TestSystem4+JobForComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        
        public struct JobDebugData23Unsafe { // ME.BECS.Tests.Tests_Queries+EntityCreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.EntityCreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test1Component> ME_BECS_Tests_Test1Component;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        
        public struct JobDebugData24Unsafe { // ME.BECS.Tests.Tests_Queries+Job1
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData25Unsafe { // ME.BECS.Tests.Tests_Queries+Job1Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        
        public struct JobDebugData26Unsafe { // ME.BECS.Tests.Tests_Queries+Job2
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData27Unsafe { // ME.BECS.Tests.Tests_Queries+Job2Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
        }
        
        public struct JobDebugData28Unsafe { // ME.BECS.Tests.Tests_Queries+JobComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.JobComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        
        public struct JobDebugData29Unsafe { // ME.BECS.Tests.Tests_Queries+ScheduleParallelJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.ScheduleParallelJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData30Unsafe { // ME.BECS.Tests.Tests_Systems_Graph+TestSystem1+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Systems_Graph.TestSystem1.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData31Unsafe { // ME.BECS.Tests.Tests_Systems_Graph+TestSystem2_1+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData32Unsafe { // ME.BECS.Tests.Tests_Systems_Graph+TestSystem2_2+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData33Unsafe { // ME.BECS.Tests.Tests_Systems_Graph+TestSystem3+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Systems_Graph.TestSystem3.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        
        public struct JobDebugData34Unsafe { // ME.BECS.Units.HitSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.HitSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Units.DamageTookComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        
        public struct JobDebugData35Unsafe { // ME.BECS.Views.Jobs+JobAddToScene
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAddToScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Views.IsViewRequested> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        
        public struct JobDebugData36Unsafe { // ME.BECS.Views.Jobs+JobAssignViews
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAssignViews jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Views.AssignViewComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.AssignViewComponent> ME_BECS_Views_AssignViewComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        
        public struct JobDebugData37Unsafe { // ME.BECS.Views.Jobs+JobRemoveFromScene
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobRemoveFromScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Views.ViewComponent> c0;
        }
        
        public struct JobDebugData38Unsafe { // ME.BECS.Timers.TimersAutoDestroyUpdateSystem`1+Job[[ME.BECS.Timers.DefaultTimerAutoDestroyComponent, ME.BECS.Timers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Timers.TimersAutoDestroyUpdateSystem<ME.BECS.Timers.DefaultTimerAutoDestroyComponent>.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Timers.DefaultTimerAutoDestroyComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Timers.DefaultTimerAutoDestroyComponent> ME_BECS_Timers_DefaultTimerAutoDestroyComponent;
        }
        
        public struct JobDebugData39Unsafe { // ME.BECS.Timers.TimersMsAutoDestroyUpdateSystem`1+Job[[ME.BECS.Timers.DefaultTimerMsAutoDestroyComponent, ME.BECS.Timers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Timers.TimersMsAutoDestroyUpdateSystem<ME.BECS.Timers.DefaultTimerMsAutoDestroyComponent>.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Timers.DefaultTimerMsAutoDestroyComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Timers.DefaultTimerMsAutoDestroyComponent> ME_BECS_Timers_DefaultTimerMsAutoDestroyComponent;
        }
        
        public struct JobDebugData40Unsafe { // ME.BECS.Timers.TimersMsUpdateSystem`1+Job[[ME.BECS.Timers.DefaultTimerMsComponent, ME.BECS.Timers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Timers.TimersMsUpdateSystem<ME.BECS.Timers.DefaultTimerMsComponent>.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Timers.DefaultTimerMsComponent> c0;
        }
        
        public struct JobDebugData41Unsafe { // ME.BECS.Timers.TimersUpdateSystem`1+Job[[ME.BECS.Timers.DefaultTimerComponent, ME.BECS.Timers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Timers.TimersUpdateSystem<ME.BECS.Timers.DefaultTimerComponent>.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Timers.DefaultTimerComponent> c0;
        }
        
        public struct JobDebugData42Unsafe { // ME.BECS.Attack.CanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.CanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackSectorComponent> ME_BECS_Attack_AttackSectorComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackVisualComponent> ME_BECS_Attack_AttackVisualComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.CanFireWhileMovesTag> ME_BECS_Attack_CanFireWhileMovesTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
        }
        
        public struct JobDebugData43Unsafe { // ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem+TargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        
        public struct JobDebugData44Unsafe { // ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem+TargetsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        
        public struct JobDebugData45Unsafe { // ME.BECS.Attack.FireSystem+FireTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.FireSystem.FireTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackVisualComponent> ME_BECS_Attack_AttackVisualComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.DamageOverrideComponent> ME_BECS_Bullets_DamageOverrideComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.FirePointComponent> ME_BECS_Bullets_FirePointComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        
        public struct JobDebugData46Unsafe { // ME.BECS.Attack.FireSystem+FireTargetsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.FireSystem.FireTargetsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackVisualComponent> ME_BECS_Attack_AttackVisualComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.DamageOverrideComponent> ME_BECS_Bullets_DamageOverrideComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.FirePointComponent> ME_BECS_Bullets_FirePointComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        
        public struct JobDebugData47Unsafe { // ME.BECS.Attack.ReloadSystem+ReloadJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ReloadSystem.ReloadJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
        }
        
        public struct JobDebugData48Unsafe { // ME.BECS.Attack.ResetCanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ResetCanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
        }
        
        public struct JobDebugData49Unsafe { // ME.BECS.Attack.RotateWhileAttackSystem+IdleJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.IdleJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        
        public struct JobDebugData50Unsafe { // ME.BECS.Attack.SearchTargetSystem+SearchTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.SearchTargetSystem.SearchTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        
        public struct JobDebugData51Unsafe { // ME.BECS.Attack.StopWhileAttackSystem+JobRemove
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobRemove jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        
        public struct JobDebugData52Unsafe { // ME.BECS.Bullets.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Bullets.BulletAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletEffectOnDestroy> ME_BECS_Bullets_BulletEffectOnDestroy;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.DamageOverrideComponent> ME_BECS_Bullets_DamageOverrideComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnHitComponent> ME_BECS_Units_UnitEffectOnHitComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        
        public struct JobDebugData53Unsafe { // ME.BECS.Bullets.FlySystem+FlyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.FlySystem.FlyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Bullets.BulletAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.TargetReachedComponent> ME_BECS_Bullets_TargetReachedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData54Unsafe { // ME.BECS.Commands.CommandAttackSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        
        public struct JobDebugData55Unsafe { // ME.BECS.Commands.CommandAttackSystem+MoveJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.MoveJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitCommandGroupAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
        }
        
        public struct JobDebugData56Unsafe { // ME.BECS.Commands.CommandBuildSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitCommandGroupAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandBuild> ME_BECS_Commands_CommandBuild;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        
        public struct JobDebugData57Unsafe { // ME.BECS.Commands.CommandMoveSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandMoveSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitCommandGroupAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        
        public struct JobDebugData58Unsafe { // ME.BECS.FogOfWar.CreateSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Players.TeamAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        
        public struct JobDebugData59Unsafe { // ME.BECS.FogOfWar.CreateSystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Players.TeamAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        
        public struct JobDebugData60Unsafe { // ME.BECS.Pathfinding.FollowPathSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        
        public struct JobDebugData61Unsafe { // ME.BECS.Pathfinding.FollowPathSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        
        public struct JobDebugData62Unsafe { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        
        public struct JobDebugData63Unsafe { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        
        public struct JobDebugData64Unsafe { // ME.BECS.Pathfinding.LookAtSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.LookAtSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        
        public struct JobDebugData65Unsafe { // ME.BECS.QuadTreeInsertSystem+CollectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeInsertSystem.CollectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeElement> ME_BECS_QuadTreeElement;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeHeightComponent> ME_BECS_QuadTreeHeightComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData66Unsafe { // ME.BECS.QuadTreeInsertSystem+CollectRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeInsertSystem.CollectRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeElement> ME_BECS_QuadTreeElement;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeElementRect> ME_BECS_QuadTreeElementRect;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeHeightComponent> ME_BECS_QuadTreeHeightComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData67Unsafe { // ME.BECS.QuadTreeQuerySystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeQuerySystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData68Unsafe { // ME.BECS.Tests.Tests_Aspects+TestJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.Test2Aspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
        }
        
        public struct JobDebugData69Unsafe { // ME.BECS.Tests.Tests_Aspects+TestSetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestSetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.Test2Aspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
        }
        
        public struct JobDebugData70Unsafe { // ME.BECS.Tests.Tests_Queries+TestA1Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA1Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.TestAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.Test5Component> ME_BECS_Tests_Test5Component;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        
        public struct JobDebugData71Unsafe { // ME.BECS.Tests.Tests_Queries+TestA2Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA2Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.TestAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        
        public struct JobDebugData72Unsafe { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData73Unsafe { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateLocalMatrixJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateLocalMatrixJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
        }
        
        public struct JobDebugData74Unsafe { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData75Unsafe { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+ClearJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.ClearJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData76Unsafe { // ME.BECS.Units.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.SelectionGroupComponent> ME_BECS_Units_SelectionGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnDestroyComponent> ME_BECS_Units_UnitEffectOnDestroyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitIsDeadTag> ME_BECS_Units_UnitIsDeadTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitSelectionGroupComponent> ME_BECS_Units_UnitSelectionGroupComponent;
        }
        
        public struct JobDebugData77Unsafe { // ME.BECS.Units.SteeringSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        
        public struct JobDebugData78Unsafe { // ME.BECS.Units.SteeringWithAvoidanceSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringWithAvoidanceSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        
        public struct JobDebugData79Unsafe { // ME.BECS.UnitsHealthBars.DrawHealthBarsSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Views.CameraComponent> ME_BECS_Views_CameraComponent;
        }
        
        public struct JobDebugData80Unsafe { // AShooter.Systems.MovementSystem+MoveJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public AShooter.Systems.MovementSystem.MoveJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<AShooter.Components.MoveInputComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<AShooter.Components.MoveInputComponent> AShooter_Components_MoveInputComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<AShooter.Components.MoveSpeedComponent> AShooter_Components_MoveSpeedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        
        public struct JobDebugData81Unsafe { // ME.BECS.Attack.MoveToAttackerSystem+ComebackAfterAttackJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.ComebackAfterAttackJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Attack.ComebackAfterAttackComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackerFollowDistanceComponent> ME_BECS_Attack_AttackerFollowDistanceComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent> ME_BECS_Attack_ComebackAfterAttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        
        public struct JobDebugData82Unsafe { // ME.BECS.Attack.MoveToAttackerSystem+MoveToAttackerJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Units.DamageTookEvent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent> ME_BECS_Attack_ComebackAfterAttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
        }
        
        public struct JobDebugData83Unsafe { // ME.BECS.Attack.MoveToAttackerSystem+StopOnTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.UnitAttackCommandComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent> ME_BECS_Attack_ComebackAfterAttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
        }
        
        public struct JobDebugData84Unsafe { // ME.BECS.Attack.MoveToAttackerSystem+UpdatePathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.UpdatePathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitCommandGroupAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.CommandAttack> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
        }
        
        public struct JobDebugData85Unsafe { // ME.BECS.Attack.RotateWhileAttackSystem+RotateAttackSensorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Attack.RotateAttackSensorComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.RotateAttackSensorComponent> ME_BECS_Attack_RotateAttackSensorComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData86Unsafe { // ME.BECS.Attack.SearchTargetSystem+SearchTargetsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.SearchTargetSystem.SearchTargetsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a2;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Attack.AttackTargetsCountComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsCountComponent> ME_BECS_Attack_AttackTargetsCountComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        
        public struct JobDebugData87Unsafe { // ME.BECS.Attack.StopWhileAttackSystem+JobSet
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobSet jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        
        public struct JobDebugData88Unsafe { // ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> ME_BECS_FogOfWar_QuadTreeQueryFogOfWarFilter;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        public struct JobDebugData89Unsafe { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsWithChildrenJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.IsFirstLevelComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        
        #endif
        
    }
     
}
