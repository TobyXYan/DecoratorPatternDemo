using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternDemo
{
    public class Espresso:Beverage
    {
        public override int Cost()
        {
            return 1;
        }
        public override void GetDesc()
        {
            Console.WriteLine("Espresso Ordered");
        }
    }
}
