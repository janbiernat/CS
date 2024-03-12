using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /*--== Punkty na procenty (%) ==--
          Copyright (c)by Jan T. Biernat*/
        static string JustujDoPrawej(string Str = "", int IleMaks = 0)
        {
            //JustujDoPrawej - Dodaj znaki puste (tzw. znaki spacji) przed podanym ciągiem znaków.
            string _T = "";
            if ((Str.Trim() != "") && (IleMaks > Str.Length))
            {
                for (int I = 0; I < (IleMaks - Str.Length); I++) { _T += " "; }
            }
            return _T + Str.Trim();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--== Punkty na procenty (%) ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat\n\n");
            //Pobierz dane z klawiatury.
            int Punkty = 0;
            Console.Write("Maksymalna ilość punktów: ");
            Punkty = int.Parse(Console.ReadLine());
            //Przeliczenie punktów na procenty (%).
            if (Punkty > 0)
            {
                Console.WriteLine("\n\nPunkty |  %");
                Console.WriteLine("-------------");
                for (int I = 0; I < Punkty; I++)
                {
                    Console.WriteLine(JustujDoPrawej((I + 1).ToString(), 6)
                        +" | "+ JustujDoPrawej(((I + 1) * 100 / Punkty).ToString(), 3));
                }
            }
            //Naciśnij dowolny klawisz...
            Console.Write("\n\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}