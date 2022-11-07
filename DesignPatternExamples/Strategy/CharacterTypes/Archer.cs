using DesignPatternExamples.Strategy.WeaponBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.CharacterTypes
{
    class Archer : Character
    {

        public Archer(IWeaponBehavior weaponBehavior)
        {

            this.weaponBehavior = new BowBehavior();
        }

        public override void fight()
        {
            weaponBehavior.useWeapon();
        }
    }


}
