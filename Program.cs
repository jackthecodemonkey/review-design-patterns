using DesignPattern.OOP;
using DesignPattern.OOP.Decorator;
using DesignPattern.OOP.Factory_Pattern;
using DesignPattern.OOP.ObserverPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza basicPizza = new TomatoSource(new Mozzarella(new PlainPizza()));

            Console.WriteLine(basicPizza.getCost());
            Console.WriteLine(basicPizza.getDescription());

        }

    }
}
