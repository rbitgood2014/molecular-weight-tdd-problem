using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace molecular_weight
{
    public class Element
    {
        public string ElementName { get; private set;}
        public int AtomicNumber { get; private set; }
        public string Symbol { get; private set; }
        public double Weight { get; private set; }

        public Element(string ElementName, int AtomicNumber, string Symbol, double Weight)
        {
            this.ElementName = ElementName;
            this.AtomicNumber = AtomicNumber;
            this.Symbol = Symbol;
            this.Weight = Weight;

        }

    }
}
