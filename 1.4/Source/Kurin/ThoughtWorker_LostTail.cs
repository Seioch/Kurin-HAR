using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Kurin
{
    public class ThoughtWorker_LostTail : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (!p.RaceProps.Humanlike)
            {
                return false;
            }
            if (!p.IsKurin())
            {
                return false;
            }

            if (p.story.GetBackstory(BackstorySlot.Childhood).defName == "Kurin_BackstoryChild_15") // Prevent single tail syndrome from causing this thought. 
            {
                return false;
            }

            // Log.Message("Single-Tailed Backstory detected, removing tails");
            int numMissingTails = 0;
            foreach (BodyPartRecord record in p.RaceProps.body.GetPartsWithDef(Kurin_DefOf.Kurin_Tail))
            {
                if (p.health.hediffSet.HasHediff(HediffDefOf.MissingBodyPart, record)) // Only increments on MISSING a tail. Should not count a bionic/fake tail.
                {
                    numMissingTails += 1;
                }
            }

            if (numMissingTails > 0)
            {
                return ThoughtState.ActiveAtStage(numMissingTails - 1);
            }
            return false;
        }
    }
}
