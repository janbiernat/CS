using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== % udział poszczególnych ocen w całkowitej ilości ocen ==--
  Copyright (c)by Jan T. Biernat
*/
namespace OcenyNaProcent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--== % udział poszczególnych ocen w całkowitej ilości ocen ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat \n \n");
            //
            int Suma = 0;
            int[] Oceny = new int[6];
            float Procent = 0;
            //
            //Pobieranie danych od użytkownika.
            for (int I = 0; I < 6; I++)
            {
                Console.Write("Ocena ");
                Console.Write((6 - I));
                Console.Write(": ");
                Oceny[I] = 0;
                Oceny[I] = int.Parse(Console.ReadLine());
                if (Oceny[I] < 0) { Oceny[I] = 0; }
                Suma += Oceny[I];
            }
            //
            //Raport: Udział procentowy poszczególnych ocen.
            if (Suma > 0)
            {
                Console.Write("\nSuma ocen: ");
                Console.Write(Suma);
                Console.WriteLine("\n \n Ocena | Ilość |     %");
                Console.WriteLine(new string('-', 25));
                for (int I = 0; I < 6; I++)
                {
                    Console.Write((6 - I).ToString().PadLeft(6));
                    Console.Write(" | ");
                    Console.Write(Oceny[I].ToString().PadLeft(5));
                    Console.Write(" | ");
                    Procent = 0; Procent = (Oceny[I] * 100f / Suma);
                    Console.Write(Procent.ToString("F2").PadLeft(6));
                    Console.Write("\n");
                }
            }
            //
            //Naciśnij dowolny klawisz.
            Console.Write("\n \nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}