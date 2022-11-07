using DesignPatternExamples.Strategy.WeaponBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.CharacterTypes
{
    class Cleric : Character
    {
        public Cleric(IWeaponBehavior weaponBehavior)
        {
            this.weaponBehavior = new CharmBehavior();
        }

        public override void fight()
        {
            this.weaponBehavior.useWeapon();
        }
    }
}
