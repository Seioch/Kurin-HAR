using HarmonyLib;
using Verse;

namespace KurinHAR
{
    /// <summary>
    /// Applies the TOF lovin mood gene patches when RimWorld loads the assembly.
    /// </summary>
    [StaticConstructorOnStartup]
    public static class LovinMoodGeneMod
    {
        static LovinMoodGeneMod()
        {
            new Harmony("KurinHAR.LovinMoodGene").PatchAll();
        }
    }
}
