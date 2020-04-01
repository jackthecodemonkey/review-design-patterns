using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Factory_Pattern
{
    public class UFOEnmeyShip : EnemyShip
    {
        public UFOEnmeyShip()
        {
            this.name = "UFO Enemy Ship";
            this.amtDamage = 20.0;
        }
    }
}
