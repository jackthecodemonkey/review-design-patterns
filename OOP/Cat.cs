using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP
{
    public class Cat : Animal
    {
        public Cat() : base(new ItFly())
        {
            this.sounds = "Meou";
        }
    }
}
