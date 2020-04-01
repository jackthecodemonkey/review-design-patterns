using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.ObserverPattern
{
    public class StockObserver : Observer
    {
        public double ibmPrice { get; set; }
        public double aaplPrice { get; set; }
        public double googPrice { get; set; }

        private static int observerIDTracker = 0;

        private int observerID;

        private Subject stockGrabber;

        public StockObserver(Subject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            observerID = ++observerIDTracker;
        }

        public void update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.googPrice = googPrice;

            printPrices();
        }

        public void printPrices()
        {
            Console.WriteLine(ibmPrice);
            Console.WriteLine(aaplPrice);
            Console.WriteLine(googPrice);
        }
    }
}
