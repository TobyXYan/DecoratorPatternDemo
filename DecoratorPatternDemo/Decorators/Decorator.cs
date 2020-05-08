using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternDemo
{
    public abstract class Decorator:Beverage
    {
        protected Beverage _beverage;
    }
}
