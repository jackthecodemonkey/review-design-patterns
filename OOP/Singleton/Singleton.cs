using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
