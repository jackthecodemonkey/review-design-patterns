using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Command
{
    public interface ElectronicDevice
    {
        public void on();
        public void off();
        public void volumeUp();
        public void volumeDown();
    }
}
