using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensaEingaben
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menge;
            string Artikelname;
            decimal einzelpreis;
            decimal gesamtpreis;


            //Eingabe

            Console.WriteLine("Mensa Bestellung");

            Console.Write("Artikelname: ");
            Artikelname = Console.ReadLine();

            Console.Write("Einzelpreis (CHF): ");
            einzelpreis = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Menge: ");
            menge = Convert.ToInt32(Console.ReadLine());

            
            //Verarbeitung

            gesamtpreis = einzelpreis * menge;

            
            //Ausgabe

            Console.WriteLine();
            Console.WriteLine("Gesamtpreis CHF " + gesamtpreis);





            Console.ReadKey();











        }
    }
}
