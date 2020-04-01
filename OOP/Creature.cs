using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP
{
    abstract public class Creature
    {
        abstract public string name { get; set; }
        abstract public int weight { get; set; }
        abstract public string sound { get; set; }

    }
}
