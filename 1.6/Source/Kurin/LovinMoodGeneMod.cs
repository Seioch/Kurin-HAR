using HarmonyLib;
using RimWorld;
using System.Linq;
using System.Reflection;
using Verse;

namespace KurinHAR
{
    /// <summary>
    /// Applies the TOF lovin mood gene patches when RimWorld loads the assembly.
    /// THIS PATCH IS DISABLED DUE TO NEEDING TO TRANSPILE THE JOBDRIVER FOR LOVIN
    /// </summary>
    //[StaticConstructorOnStartup]
    //public static class LovinMoodGeneMod
    //{
    //    private const string KurinHARPatchname = "KurinHAR.LovinMoodGene";
    //    static LovinMoodGeneMod()
    //    {
    //        MethodInfo original = AccessTools.Method( typeof(MemoryThoughtHandler), "TryGainMemory", new[] { typeof(Thought_MemorySocial), typeof(Pawn) });

    //        if (original == null)
    //        {
    //            Log.Error(
    //                "[KurinHAR] Reflection could not find MemoryThoughtHandler.TryGainMemory(Thought_MemorySocial, Pawn).");
    //            return;
    //        }

    //        Patches patchInfo = Harmony.GetPatchInfo(original);

    //        if (patchInfo != null && patchInfo.Postfixes.Any(p => p.owner == KurinHARPatchname))
    //        {
    //            Log.Message("[KurinHAR] Postfix already applied for KurinHAR.LovinMoodGene. Skipping.");
    //            return;
    //        }

    //        Harmony harmony = new Harmony(KurinHARPatchname);
    //        harmony.Patch(
    //            original,
    //            postfix: new HarmonyMethod(
    //                AccessTools.Method(
    //                    typeof(MemoryThoughtHandler_LovinMoodGenePatch),
    //                    nameof(MemoryThoughtHandler_LovinMoodGenePatch.Postfix))));

    //    }
    //}
}
