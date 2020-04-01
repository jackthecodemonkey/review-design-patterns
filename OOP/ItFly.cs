using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP
{
    public class ItFly : Iflyable
    {
        public string fly()
        {
            return "I can fly";
        }
    }

    public class CantFly : Iflyable
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}
