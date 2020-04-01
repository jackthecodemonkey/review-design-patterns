using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Factory_Pattern
{
    public abstract class EnemyShip
    {
        public string name { get; set; }

        public double amtDamage { get; set; }

        public void followHeroShip()
        {
            Console.WriteLine(name + " is following the hero");
        }

        public void displayEnemyShip()
        {
            Console.WriteLine(name + " is on the screen");
        }

        public void enmeyShipShoots()
        {
            Console.WriteLine(name + " is following the hero" + amtDamage);
        }
    }
}
