using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Decorator
{
    public class PlainPizza : Pizza
    {
        public double getCost()
        {
            return 4;
        }

        public string getDescription()
        {
            return "Thin Dough";
        }
    }
}
