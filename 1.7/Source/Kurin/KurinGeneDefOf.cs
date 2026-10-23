using RimWorld;
using Verse;

namespace KurinHAR
{
    /// <summary>
    /// Provides strongly typed references to the gene and mood memory defined by this mod.
    /// </summary>
    [DefOf]
    public static class KurinHARDefOf
    {
        /// <summary>The gene that grants additional mood after lovin.</summary>
        public static GeneDef Kurin_Fertile;

        /// <summary>The additional +6 mood memory.</summary>
        public static ThoughtDef Kurin_FertileMemory;

        static KurinHARDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(KurinHARDefOf));
        }
    }
}
