using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Kurin
{
    public class PawnRenderSubWorker_NoDraw : PawnRenderSubWorker
    {
        public override bool CanDrawNowSub(PawnRenderNode node, PawnDrawParms parms)
        {
            if (parms.pawn.IsKurin()) // Check if the pawn is a Kurin. If so, do not draw vanilla bionic decals. 
            {
                return false;
            }
            return true;
        }

        public PawnRenderSubWorker_NoDraw()
        { }
    }
}
