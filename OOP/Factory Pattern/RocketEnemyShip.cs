using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Factory_Pattern
{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            this.name = "ROcket ENenmy Ship";
            this.amtDamage = 10.0;
        }
    }
}
