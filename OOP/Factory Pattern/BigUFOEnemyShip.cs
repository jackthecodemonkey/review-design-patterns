using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Factory_Pattern
{
    class BigUFOEnemyShip : UFOEnmeyShip
    {
        public BigUFOEnemyShip()
        {
            this.name = "Big UFO Enemy Ship";
            this.amtDamage = 40.0;
        }
    }
}
