using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.WeaponBehaviors
{
    internal class CharmBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Praying for healing team members");
        }
    }
}
