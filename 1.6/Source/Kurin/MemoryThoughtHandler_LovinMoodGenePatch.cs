using HarmonyLib;
using RimWorld;
using Verse;

namespace KurinHAR
{
    /// <summary>
    /// Adds the configured mood memory when vanilla records a completed lovin event.
    /// </summary>
    [HarmonyPatch(typeof(MemoryThoughtHandler), "TryGainMemory",
        new[] { typeof(Thought_Memory), typeof(Pawn) })]
    public static class MemoryThoughtHandler_LovinMoodGenePatch
    {
        /// <summary>
        /// Gives the bonus only when the lovin partner's gene exists and is currently active.
        /// </summary>
        /// <param name="__0">The memory instance requested by vanilla.</param>
        /// <param name="otherPawn">The second argument of the patched method: the lovin partner.</param>
        /// <param name="___pawn">The pawn owning this memory handler.</param>
        public static void Postfix(Thought_Memory __0, Pawn otherPawn, Pawn ___pawn)
        {
            if (!ModsConfig.BiotechActive
                || __0 == null
                || __0.def != ThoughtDefOf.GotSomeLovin
                || ___pawn == null
                || otherPawn == null
                || otherPawn.genes == null
                || ___pawn.needs == null
                || ___pawn.needs.mood == null)
            {
                return;
            }

            Gene gene = otherPawn.genes.GetGene(KurinHARDefOf.Kurin_Fertile);
            if (gene == null || !gene.Active)
            {
                return;
            }

            ___pawn.needs.mood.thoughts.memories.TryGainMemory(
                KurinHARDefOf.Kurin_FertileMemory, null);
        }
    }
}
