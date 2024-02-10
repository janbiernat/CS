using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== Obsługa wyjątku ==--
  try ... catch ...
  Copyright (c)by Jan T. Biernat
 */
namespace obsluga_wyjatkow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--== Obsługa wyjątku ==--\n");
            float A = 0, B = 0;
            try
            {
                Console.Write("A: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                B = int.Parse(Console.ReadLine());
                Console.Write("\nWynik: " + A + " / " + B + " = ");
                if (B == 0) { Console.Write("BŁĄD -?Dzielenie przez zero jest niewykonalne!\n"); }
                else { Console.Write((A / B)+"\n"); }
            }
            catch
            {
                Console.WriteLine("BŁĄD -?Niestety wystąpił błąd przy podawaniu danych!");
            }
            //Naciśnij dowolny klawisz...
            Console.Write("\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}