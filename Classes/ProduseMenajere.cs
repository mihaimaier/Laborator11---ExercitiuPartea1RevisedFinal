using Laborator11___Exercitiu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11___Exercitiu.Classes
{
    class ProduseMenajere : Product, ITaxesCalculatorStrategy
    {
        public double ApplyTaxes()
        {
            double tax = 0.19;
            double PriceAfterTax = GrossPrice * tax;
            return this.PriceAfterTax;
        }
        public ProduseMenajere(string Name, double GrossPrice) :base(Name,GrossPrice)
        {
            this.Name = Name;
            this.GrossPrice = GrossPrice;
        }
        public string Name { get; }

        public double GrossPrice { get; }

        public double PriceAfterTax
        {
            get { return this.PriceAfterTax; }
        }
    }
}
