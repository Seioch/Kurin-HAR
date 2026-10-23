using HarmonyLib;
using RimWorld;
using Verse;

namespace KurinHAR
{
    /// <summary>
    /// Adds the configured mood memory when vanilla records a completed lovin event.
    /// </summary>
    // [HarmonyPatch(typeof(JobDriver_Lovin), "MakeNewToils", new[] { typeof(Thought_Memory), typeof(Pawn) })]
    [HarmonyPatch(typeof(JobDriver_Lovin), "<MakeNewToils>b__12_4")]
    public static class MemoryThoughtHandler_LovinMoodGenePatch
    {
        /// <summary>
        /// Gives the bonus only when the lovin partner's gene exists and is currently active.
        /// </summary>
        /// <param name="__0">The memory instance requested by vanilla.</param>
        /// <param name="otherPawn">The second argument of the patched method: the lovin partner.</param>
        /// <param name="___pawn">The pawn owning this memory handler.</param>
        //public static void Postfix(ref Pawn ___pawn, ref Pawn Partner)
        //{
        //    if (!ModsConfig.BiotechActive
        //        || ___pawn == null
        //        || Partner == null
        //        || Partner.genes == null
        //        || ___pawn.needs == null
        //        || ___pawn.needs.mood == null)
        //    {
        //        return;
        //    }

        //    Gene gene = Partner.genes.GetGene(KurinHARDefOf.Kurin_Fertile);
        //    if (gene == null || !gene.Active)
        //    {
        //        return;
        //    }

        //    ___pawn.needs.mood.thoughts.memories.TryGainMemory(
        //        KurinHARDefOf.Kurin_FertileMemory, Partner, null);
        //}
    }
}
