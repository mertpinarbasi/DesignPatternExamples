using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Decorator
{
    class Espresso : Beverage
    {
        String description;


        public Espresso()
        {
            this.description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
