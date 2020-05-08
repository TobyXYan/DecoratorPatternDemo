using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternDemo
{
    public class Decaf:Beverage
    {
        public override int Cost() { return 2; }
        public override void GetDesc()
        {
            Console.WriteLine("Decaf Ordered");
        }
    }
}
