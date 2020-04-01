using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP
{
    public class Animal
    {
        public string name { get; set; }

        private Iflyable fly;

        public Animal(Iflyable newFlyType)
        {
            fly = newFlyType;
        }

        public int weight {
            get
            {
                return weight;
            } 
            
            set 
            { 
                if(value > 0)
                {
                    weight = value;
                } 
                else
                {
                    Console.WriteLine("Weight must be bigger than 0");
                }
            } 
        }
 
        public string sounds { get; set; }

        public string tryToFly()
        {
            return fly.fly();
        }
        
    }
}
