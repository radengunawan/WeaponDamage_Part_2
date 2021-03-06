using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamage_Part_2
{
    abstract class WeaponDamage  //<--Abstract class cannot be instatiated, can ONLY be INHERITED / EXTENDED
    {
        public int Damage { 
            get; 
            protected set; }

        private int roll;
        public int Roll
        {
            get { return this.roll; }
            set
            {
                this.roll = value;
                CalculateDamage();
            }
        }

        private bool magic;
        public bool Magic
        {
            get { return this.magic; }
            set
            {
                this.magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        public bool Flaming
        {
            get
            {
                return this.flaming;
            }
            set
            {
                this.flaming = value;
                CalculateDamage();
            }
        }

        protected abstract void CalculateDamage(); //<-- ABSTRACT METHOD: NOT IMPLEMENTED AT ALL
        //{
        //    Console.WriteLine("Anything");
       // }

        public WeaponDamage(int startingRoll)
        {
            this.roll = startingRoll;
            CalculateDamage();
        }
    }
}
