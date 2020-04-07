using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Command
{
    public class TurnTVOff : Command
    {
        ElectronicDevice theDevice;
        public TurnTVOff(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.off();
        }
    }
}
