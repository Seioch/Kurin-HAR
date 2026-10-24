using HarmonyLib;
using Verse;

namespace Kurin
{
    [StaticConstructorOnStartup]
    public static class HarmonyInit
    {
        static HarmonyInit()
        {
            new Harmony("seioch.kurin.har.harmony").PatchAll();
        }
    }
}
