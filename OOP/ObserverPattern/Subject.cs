using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.ObserverPattern
{
    public interface Subject
    {
        public void register(Observer o);
        public void unregister(Observer o);
        public void notifyObserver();
    }
}
