using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Decorator
{

    public abstract class Beverage
    {
        String description = "Unknown Beverage";

        public String GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
