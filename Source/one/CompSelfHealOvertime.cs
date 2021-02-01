using System;
using Verse;
using RimWorld;

namespace Sayers
{
    public class CompSelfHealOvertime : ThingComp
    {

    }
    public class CompProperties_SelfHealOvertime : CompProperties
    {
        public double detlaHpPerSec = 0;
        public int ticksBetweenHeal = -1;
        public CompProperties_SelfHealOvertime() : base(typeof(CompSelfHealOvertime))
        {
        }
        public CompProperties_SelfHealOvertime(Type cc) : base(cc == typeof(ThingComp) ? typeof(CompSelfHealOvertime) : cc)
        {
        }
    }
}
