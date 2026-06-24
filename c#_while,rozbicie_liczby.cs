using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== Rozbicie liczby ==--
  Copyright (c)by Jan T. Biernat
*/
namespace RozbicieLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--== Rozbicie liczby ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat \n \n");
            //
            string[] Opis = { "jednosci"
                            , "dziesiatki"
                            , "setki"
                            , "tysiace"
                            , "dziesiatki tysiecy"
                            , "setki tysiecy"
                            , "miliony"
                            , "dziesiatki milionow"
                            , "setki milionow"
                            , "miliard" };
            int L = 0, A = 0;
            //
            //Pobieranie danych od użytkownika.
            Console.Write("Liczba: ");
            L = int.Parse(Console.ReadLine());
            if(L < 1) { L = 1; }
            //
            //Rozbij liczbę.
            while (L > 0)
            {
                if (A > 0) { Console.Write(", \n"); }
                Console.Write((A + 1).ToString().PadLeft(2));
                Console.Write(") ");
                Console.Write((L % 10));
                Console.Write(" - ");
                Console.Write(Opis[A]);
                L = L / 10;
                A++;
            }
            Console.Write(".");
            //
            //Naciśnij dowolny klawisz.
            Console.Write("\n \nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}