using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternDemo
{
    public class CaramelDecorator:Decorator
    {

        public CaramelDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override void GetDesc()
        {
            _beverage.GetDesc();
            Console.WriteLine("Add Caramel to Cofffe");
        }

        public override int Cost()
        {
            return 1 + _beverage.Cost();
        }

    }
}
