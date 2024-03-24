using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Kurin
{
    internal static class KurinHelpers
    {
        internal static bool IsKurin(this Pawn pawn) => pawn.kindDef.race.defName.ToLower().Contains("kurin");
    }
}
