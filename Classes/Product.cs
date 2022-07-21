using Laborator11___Exercitiu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11___Exercitiu.Classes
{
    class Product : IReceipt
    {
        private readonly Guid Id;
        private const string Currency = "RON";

        public Product(string Name, double GrossPrice)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.GrossPrice = GrossPrice;
            //this.GetTag = $"{Id} {Name} {PriceAfterTax}";
        }
        public string Name { get; }

        public double GrossPrice { get; }

        public double PriceAfterTax { get; }

        public Guid Barcode { get { return Id; } }

        public string GetTag { get { return GetTag; } }

        public string Receipt()
        {
            return $"{GetTag}";
        }

        public void PrintReceipt()
        {
            Console.WriteLine($" Guid: {Barcode} \n Product Name: {Name} \n Net Price: {PriceAfterTax} {Currency}");
        }
    }
}
