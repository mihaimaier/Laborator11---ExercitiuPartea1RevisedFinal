using Laborator11___Exercitiu.Classes;
using System;

namespace Laborator11___Exercitiu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care va modela un produs comercial.Un produs este caracterizat de un id de tip guid,
            //un nume de tip string si un pret brut(grossPrice) de tip double.
            //
            //Fiecarui tip de produs ii este specifica o
            //strategie de calcul a pretului net(ITaxesCalculator) care va dispune de o singura metoda(ApplyTaxes)
            //care va calcula pretul net primind ca parametru pretul brut.

            //In functie de tipul produsului taxele vor varia astfel:

            //• Produse alimentare : taxele sunt in valoare de 9 % tva(rezultatul va fi pret + 0.09 * pret)
            //o Tipuri de produse alimentare
            //▪ paine, 2.5 ron pret brut
            //▪ Ulei 4 lei pret brut

            //• Produse menajere : tva 19 %
            //o Tipuri de produse menajere
            //▪ Mop 5 ron pret brut
            //▪ Detergent de vase 15 lei pret brut

            //• Combustibil: Tva 19 %, 1.8 ron / l acciza, 1.3 ron / l taxa de drum
            //      o Tipuri de combustibil
            //▪ Benzina 5.2 ron / l pret brut
            //▪ Motorina 6.2 ron / l pret brut

            //Produsele vor avea o proprietate Tag care va produce un obiect de tipul Tag(eticheta).
            //Eticheta va contine toate informatiile relevante(id, nume, pret net) precum si doua metode:

            //• O metoda va produce un string continand pe linii separate caracteristicile etichetei
            //• O metoda Tipareste, care va tipari la ecran continutul etichetei

            Product benzina = new Combustibil("Benzina", 5.2, 5);
            benzina.Receipt();
            benzina.PrintReceipt();

            Product mop = new ProduseMenajere("Mop", 5);
            mop.Receipt();
            mop.PrintReceipt();

            Product ulei = new ProduseAlimentare("Ulei", 4);
            ulei.Receipt();
            ulei.PrintReceipt();
        }
    }
}
