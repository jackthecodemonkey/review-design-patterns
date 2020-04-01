using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.ObserverPattern
{
    public class StockGrabber : Subject
    {
        private List<Observer> observers;
        public StockGrabber()
        {
            observers = new List<Observer>();
        }

        public double ibmPrice 
        {
           get
            {
                return ibmPrice;
            }
          
          set
            {
                this.ibmPrice = value;
                notifyObserver();
            } 
        }
        public double aaplPrice
        {
            get
            {
                return aaplPrice;
            }

            set
            {
                this.aaplPrice = value;
                notifyObserver();
            }
        }
        public double googPrice
        {
            get
            {
                return googPrice;
            }

            set
            {
                this.googPrice = value;
                notifyObserver();
            }
        }


        public void notifyObserver()
        {
            observers.ForEach(observer =>
            {
                observer.update(ibmPrice, aaplPrice, googPrice);
            });
        }

        public void register(Observer o)
        {
            observers.Add(o);
        }

        public void unregister(Observer o)
        {
            observers.Remove(o);
        }

    }
}
