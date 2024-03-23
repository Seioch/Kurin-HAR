using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace NineTailedFox
{
    public class CompKurinPostSpawn : ThingComp
    {
        public override void PostSpawnSetup(bool respawningAfterLoad)
        {
            base.PostSpawnSetup(respawningAfterLoad);

            Pawn pawn = parent as Pawn;

            if (pawn == null)
            {
                // Only applies against pawns.
                return;
            }

            if(pawn.IsKurin())
            {
                // Check for if the Kurin has the Single Tailed Syndrome and remove tails as needed.
                if(pawn.story.GetBackstory(BackstorySlot.Childhood).defName == "Kurin_BackstoryChild_15")
                {
                    // Log.Message("Single-Tailed Backstory detected, removing tails");
                    foreach (BodyPartRecord record in pawn.RaceProps.body.GetPartsWithDef(Kurin_DefOf.Kurin_Tail))
                    {
                        if (record.customLabel == "Right tail") // Remove the right tail
                        {
                            pawn.health.AddHediff(HediffDefOf.MissingBodyPart, record); 
                        }
                        else if (record.customLabel == "Left tail") // Remove the left tail
                        {
                            pawn.health.AddHediff(HediffDefOf.MissingBodyPart, record);
                        }
                    }
                }
            }
        }
    }
}
