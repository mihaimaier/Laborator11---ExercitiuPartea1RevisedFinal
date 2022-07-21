using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11___Exercitiu.Interfaces
{
    interface IReceipt
    {
        Guid Barcode { get; }

        string Name { get; }

        double PriceAfterTax { get; }

        void PrintReceipt()
        {
        }
    }
}
