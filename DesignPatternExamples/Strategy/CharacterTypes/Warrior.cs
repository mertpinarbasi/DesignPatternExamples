using DesignPatternExamples.Strategy.WeaponBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.CharacterTypes
{
    class Warrior : Character
    {


        public Warrior()
        {

            weaponBehavior = new SwordBehavior();
        }

        public override void fight()
        {
            weaponBehavior.useWeapon();
        }
    }
}
