using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy
{
    abstract class Character
    {
        protected IWeaponBehavior? weaponBehavior;
        public abstract void fight();

        public void SetWeapon(IWeaponBehavior w)
        {
            weaponBehavior = w;
            Console.WriteLine("weapon changed!");
        }



    }
}
