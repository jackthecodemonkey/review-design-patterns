using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Command
{
    public class Television : ElectronicDevice
    {
        private int volume = 0;
        public void off()
        {
            Console.WriteLine("TV is off");
        }

        public void on()
        {
            Console.WriteLine("TV is on");
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("volume is down");
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("volume is up");
        }
    }
}
