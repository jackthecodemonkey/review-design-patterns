using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Decorator
{
    public class TomatoSource : ToppingDecorator
    {
        public TomatoSource(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Source");
        }
        public double getCost()
        {
            return tempPizza.getCost() + .35;
        }

        public string getDescription()
        {
            return tempPizza.getDescription() + ", Tomato Sauce";
        }
    }
}
