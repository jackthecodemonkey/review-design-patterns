using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.ObserverPattern
{
    public interface Observer
    {
        public void update(double ibmPrice, double aaplPrice, double googPrice);
    }
}
