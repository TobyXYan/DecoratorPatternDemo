using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternDemo
{
    public class SoyDecorator : Decorator
    {
        public SoyDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override int Cost()
        {
            return 2 + _beverage.Cost();
        }

        public override void GetDesc()
        {
            _beverage.GetDesc();
            Console.WriteLine("Add Soy to Cofffe");
        }
    }
}
