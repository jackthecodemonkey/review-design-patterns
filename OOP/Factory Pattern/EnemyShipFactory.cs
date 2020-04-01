using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Factory_Pattern
{
    public class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(string typeofShip)
        {
            EnemyShip newShip = null;

            if (typeofShip == "U")
            {
                newShip = new UFOEnmeyShip();
            } else if(typeofShip == "B")
            {
                newShip = new BigUFOEnemyShip();
            } else
            {
                newShip = new RocketEnemyShip();
            }
            return newShip;
        }
    }
}
