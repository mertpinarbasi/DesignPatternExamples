using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Decorator

{
    public abstract class CondimentDecorator : Beverage
    {
        Beverage beverage;

        public abstract String GetDescription();
    }
}
