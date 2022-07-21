using Laborator11___Exercitiu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11___Exercitiu.Classes
{
    class ProduseAlimentare : Product, ITaxesCalculatorStrategy
    {
        public double ApplyTaxes()
        {
            double tax = 0.09;
            double PriceAfterTax = GrossPrice + (GrossPrice * tax);
            return this.PriceAfterTax;
        }
        public ProduseAlimentare(string Name, double GrossPrice) :base(Name,GrossPrice)
        {
            this.Name = Name;
            this.GrossPrice = GrossPrice;
        }
        public string Name { get; }

        public double GrossPrice { get; }

        public double PriceAfterTax { get { return this.PriceAfterTax; } }
    }
}
