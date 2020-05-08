using System;

namespace DecoratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverage = new Decaf();
            var soyDecorator = new SoyDecorator(new CaramelDecorator(beverage));
            soyDecorator.GetDesc();
            Console.WriteLine($"The total cost of the product is {soyDecorator.Cost()}");
            Console.ReadLine();
        }
    }
}
