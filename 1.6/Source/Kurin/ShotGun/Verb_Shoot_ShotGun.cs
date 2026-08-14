using System;
using Verse;

namespace Kurin
{
    public class Verb_Shoot_ShotGun : Verb_Shoot
    {
        protected override bool TryCastShot()
        {
            bool flag = base.TryCastShot();
            Verb_Properties_ShotGun verb_Properties_ShotGun = (Verb_Properties_ShotGun)this.verbProps;
            bool flag2 = flag && verb_Properties_ShotGun.pelletCount - 1 > 0;
            if (flag2)
            {
                for (int i = 1; i < verb_Properties_ShotGun.pelletCount; i++)
                {
                    base.TryCastShot();
                }
            }
            return flag;
        }
    }
}