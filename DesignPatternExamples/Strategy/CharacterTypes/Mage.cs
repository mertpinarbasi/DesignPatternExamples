using DesignPatternExamples.Strategy.WeaponBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.CharacterTypes
{
    class Mage : Character
    {


        public Mage(IWeaponBehavior weaponBehavior)
        {
            this.weaponBehavior = new StaffBehavior();
        }

        public override void fight()
        {
            weaponBehavior.useWeapon();
        }
    }
}
