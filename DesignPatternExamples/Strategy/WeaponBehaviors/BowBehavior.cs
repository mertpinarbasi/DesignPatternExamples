using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.WeaponBehaviors
{
    internal class BowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Shooting arrows");
        }
    }
}
