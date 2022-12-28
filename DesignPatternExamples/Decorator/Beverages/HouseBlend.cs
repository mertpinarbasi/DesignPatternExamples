﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Decorator.Beverages
{
    class HouseBlend : Beverage
    {
        String description;
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
