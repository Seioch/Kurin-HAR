using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Kurin
{
    [HarmonyPatch(typeof(Settlement), "MapGeneratorDef", MethodType.Getter)]
    public static class Kurin_Settlement_MapGeneratorDef_Patch
    {
        private static void Postfix(ref MapGeneratorDef __result, Settlement __instance)
        {
            if (__instance.Faction.def == Kurin_DefOf.Kurin_Faction)
            {
                __result = Kurin_DefOf.Kurin_Base_Faction_Republic;
            }
            if (__instance.Faction.def == Kurin_DefOf.Kurin_Faction_Hostile)
            {
                __result = Kurin_DefOf.Kurin_Base_Faction_BattleFoxes;
            }
        }
    }
}
