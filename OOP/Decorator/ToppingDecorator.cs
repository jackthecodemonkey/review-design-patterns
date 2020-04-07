using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Decorator
{
    abstract public class ToppingDecorator : Pizza
    {
        protected Pizza tempPizza;
        public ToppingDecorator(Pizza newPizza)
        {
            tempPizza = newPizza;
        }
        public double getCost()
        {
            return tempPizza.getCost();
        }

        public string getDescription()
        {
            return tempPizza.getDescription();
        }
    }
}
