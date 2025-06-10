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
    public static class ThemesMenu {
        [UnityEditor.MenuItem("ME.BECS/Themes/Default", true)] private static bool DefaultValidation() { UnityEditor.Menu.SetChecked("ME.BECS/Themes/Default", Themes.CurrentTheme == "ME.BECS.Resources/Styles/Themes/Default.uss"); return true; }
        [UnityEditor.MenuItem("ME.BECS/Themes/Default", priority = 200)] private static void Default() => Themes.CurrentTheme = "ME.BECS.Resources/Styles/Themes/Default.uss";
        [UnityEditor.MenuItem("ME.BECS/Themes/Classic", true)] private static bool ClassicValidation() { UnityEditor.Menu.SetChecked("ME.BECS/Themes/Classic", Themes.CurrentTheme == "ME.BECS.Resources/Styles/Themes/Classic.uss"); return true; }
        [UnityEditor.MenuItem("ME.BECS/Themes/Classic", priority = 201)] private static void Classic() => Themes.CurrentTheme = "ME.BECS.Resources/Styles/Themes/Classic.uss";
        [UnityEditor.MenuItem("ME.BECS/Themes/Alternative", true)] private static bool AlternativeValidation() { UnityEditor.Menu.SetChecked("ME.BECS/Themes/Alternative", Themes.CurrentTheme == "ME.BECS.Resources/Styles/Themes/Alternative.uss"); return true; }
        [UnityEditor.MenuItem("ME.BECS/Themes/Alternative", priority = 202)] private static void Alternative() => Themes.CurrentTheme = "ME.BECS.Resources/Styles/Themes/Alternative.uss";
        
    }
}
