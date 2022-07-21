using Laborator11___Exercitiu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11___Exercitiu.Classes
{
    class Combustibil : Product, ITaxesCalculatorStrategy
    {
        private readonly Guid Id;
        public double ApplyTaxes()
        {
            double tax = 0.19;
            double aciza = 1.8 / Litre;
            double taxaDrum = 1.3 / Litre;
            double PriceAfterTax = (PricePerLitre * tax) + aciza + taxaDrum;
            return this.PriceAfterTax;
        }
        public Combustibil(string Name, double GrossPrice, double Litre) : base(Name, GrossPrice)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.GrossPrice = GrossPrice;
            this.Litre = Litre;
            double GrossPricePerLitre = GrossPrice / Litre;
            this.PricePerLitre = GrossPricePerLitre;
        }
        public string Name { get; }

        public double GrossPrice { get; }

        public double Litre { get; }

        public double PricePerLitre { get; }

        public double PriceAfterTax { get { return this.PriceAfterTax; } }

        public Guid Barcode { get { return Id; } }
    }
}
