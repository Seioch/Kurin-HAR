using System;
using HarmonyLib;
using UnityEngine;
using Verse;
using AlienRace;

namespace Kurin
{

    [HarmonyPatch(typeof(PawnRenderNodeWorker), nameof(PawnRenderNodeWorker.RotationFor))]
    public static class Kurin_TailRotation_Patch
    {
        private static void Postfix(
            PawnRenderNode node,
            PawnDrawParms parms,
            ref Quaternion __result)
        {
            if (!ShouldModify(node, parms))
            {
                return;
            }

            __result = __result * Quaternion.Euler(0f, 180f, 0f);
        }

        private static bool ShouldModify(
            PawnRenderNode node,
            PawnDrawParms parms)
        {

            if (parms.pawn == null)
            {
                return false;
            }


            if (!parms.pawn.Drafted)
            {
                return false;
            }


            if (parms.facing != Rot4.North)
            {
                return false;
            }

  
            if (!(node is AlienPawnRenderNode_BodyAddon bodyAddonNode))
            {
                return false;
            }

            AlienPawnRenderNodeProperties_BodyAddon props =
                bodyAddonNode.props;

            if (props == null || props.addon == null)
            {
                return false;
            }

            return IsKurinTail(props.addon);
        }

        private static bool IsKurinTail(
            AlienPartGenerator.BodyAddon addon)
        {
            if (addon == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(addon.path))
            {
                return false;
            }

            return addon.path.StartsWith(
                "Kurin/Tail/",
                StringComparison.OrdinalIgnoreCase);
        }
    }


    [HarmonyPatch(
        typeof(AlienPawnRenderNodeWorker_BodyAddon),
        nameof(AlienPawnRenderNodeWorker_BodyAddon.OffsetFor))]
    public static class Kurin_TailOffset_Patch
    {
        private static void Postfix(
            PawnRenderNode node,
            PawnDrawParms parms,
            ref Vector3 __result)
        {

            if (parms.pawn == null)
            {
                return;
            }


            if (!parms.pawn.Drafted)
            {
                return;
            }


            if (parms.facing != Rot4.North)
            {
                return;
            }


            if (!(node is AlienPawnRenderNode_BodyAddon bodyAddonNode))
            {
                return;
            }

            AlienPawnRenderNodeProperties_BodyAddon props =
                bodyAddonNode.props;

            if (props == null || props.addon == null)
            {
                return;
            }


            if (!IsKurinTail(props.addon))
            {
                return;
            }

            __result.z -= 0.39f;
        }

        private static bool IsKurinTail(
            AlienPartGenerator.BodyAddon addon)
        {
            if (addon == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(addon.path))
            {
                return false;
            }

            return addon.path.StartsWith(
                "Kurin/Tail/",
                StringComparison.OrdinalIgnoreCase);
        }
    }
}