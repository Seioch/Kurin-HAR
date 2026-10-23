using System;
using Verse;

namespace Kurin
{
    public class PawnRenderSubWorker_NoDraw : PawnRenderSubWorker
    {
        public override bool CanDrawNowSub(PawnRenderNode node, PawnDrawParms parms)
        {
            bool flag = parms.pawn.IsKurin();
            return !flag;
        }
    }
}
