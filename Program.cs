using DesignPattern.OOP;
using DesignPattern.OOP.Factory_Pattern;
using DesignPattern.OOP.ObserverPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyShip enemyShip;

            var tmp = false;

            if (tmp)
            {
                enemyShip = new UFOEnmeyShip();
            } else
            {
                enemyShip = new RocketEnemyShip();
            }

            doSomeStuiff(enemyShip);
        }

        public static void doSomeStuiff(EnemyShip ship)
        {
            ship.displayEnemyShip();
            ship.enmeyShipShoots();
            ship.followHeroShip();
        }
    }
}
