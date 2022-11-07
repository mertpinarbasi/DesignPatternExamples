using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.WeaponBehaviors
{
    internal class StaffBehavior : IWeaponBehavior
    {
        public void useWeapon() {
            Console.WriteLine("DO MAGIC");
        }
    }
}
