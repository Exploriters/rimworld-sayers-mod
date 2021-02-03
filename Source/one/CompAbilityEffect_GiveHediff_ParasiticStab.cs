using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Sayers
{
    public class AdditionalAbility : Ability
    {
        public AdditionalAbility(Pawn pawn) : base(pawn) { }
        public AdditionalAbility(Pawn pawn, AbilityDef def) : base(pawn, def) { }

        public override bool CanCast => base.CanCast;
    }
    public class CompAbilityEffect_GiveHediff_ParasiticStab : CompAbilityEffect_GiveHediff
    {
        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            base.Apply(target, dest);

        }
    }
}
