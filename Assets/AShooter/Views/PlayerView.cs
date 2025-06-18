using AShooter.Components;
using ME.BECS;
using ME.BECS.Views;
using UnityEngine;

namespace AShooter.Views
{
    public class PlayerView : EntityView
    {
        protected override void ApplyState(in EntRO ent)
        {
            Debug.Log($"Test component: {ent.Has<PlayerComponent>()}");
        }
    }
}