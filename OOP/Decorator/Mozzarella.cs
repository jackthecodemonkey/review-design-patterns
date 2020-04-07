using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Decorator
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Dough");
            Console.WriteLine("Adding Moz");
        }
        public double getCost()
        {
            return tempPizza.getCost() + .50;
        }

        public string getDescription()
        {
            return tempPizza.getDescription() + ", Mozzarella";
        }
    }
}
