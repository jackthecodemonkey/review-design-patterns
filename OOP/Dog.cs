using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP
{
    public class Dog : Animal
    {
        public Dog() : base(new CantFly())
        {
            this.sounds = "Bark";
        }

        public void digHole() 
        {
            Console.WriteLine("Dug a hole!");
        }
    }
}
