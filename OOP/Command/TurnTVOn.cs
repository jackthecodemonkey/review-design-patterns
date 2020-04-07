using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Command
{
    public class TurnTVOn : Command
    {
        ElectronicDevice theDevice;
        public TurnTVOn(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.on();
        }
    }
}
