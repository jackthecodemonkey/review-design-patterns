using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Prototype
{
    public class Sheep : Animal
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
