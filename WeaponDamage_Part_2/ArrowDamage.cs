﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamage_Part_2
{
    class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        public ArrowDamage(int startingRoll) : base(startingRoll) { }

        //protected abstract void CalculateDamage(); //<-- from abstract class, unimplemented
        protected override void CalculateDamage()
        {
            decimal baseDamage = this.Roll * BASE_MULTIPLIER;
            if (this.Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (this.Flaming) this.Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else this.Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
