using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_HSP_Zahlenarray
{
    class Program
    {
        static void Main()
        {
            int arrayGroesse = 0;

            Console.Write("Wie viele Zahlen möchten sie eingeben? ");
            arrayGroesse = Convert.ToInt32(Console.ReadLine());

            double[] quadratzahlen = new double[arrayGroesse];

            for(int i = 0; i < arrayGroesse; i++)
            {
                Console.Write("Geben Sie die " + (i + 1) + ". Zahl ein: ");
                quadratzahlen[i] = Math.Pow(Convert.ToDouble(Console.ReadLine()),2);
            }

            Console.WriteLine("Berechne Quadratzahlen...");

            for(int i = 0; i < arrayGroesse; i++)
            {
                Console.WriteLine("Quadrat der " + (i + 1) + ". Zahl: " + quadratzahlen[i]);
            }

            Console.ReadKey();
        }
    }
}
