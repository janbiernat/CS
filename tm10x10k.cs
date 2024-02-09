using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm10x10k
{
    class Program
    {
        /*--== Tabliczka mnożenia (10x10) - kolumnowa ==--
          Copyright (c)by Jan T. Biernat
         */
        static void Main(string[] args)
        {
            short Zakres = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("--== Tabliczka mnożenia (10x10) - kolumnowa ==--\n");
                Console.WriteLine("UWAGA: Wpisanie cyfry 0 spowoduje wyjście z programu.\n\n");
                //Generowanie tabliczki mnożenia kolumnowej.
                if((Zakres > 0) && (Zakres < 11))
                {
                    Console.WriteLine("Podany zakres to: "+ Zakres.ToString()+".");
                    for (int I = 1; I < 11; I++)
                    {
                        Console.WriteLine();
                        if(I < 10) { Console.Write(" "); }
                        Console.Write(I.ToString()+" * "+ Zakres.ToString()+" = ");
                        if((I*Zakres) < 10) { Console.Write("  "); }
                        else if ((I*Zakres) < 100) { Console.Write(" "); }
                        Console.Write((I*Zakres).ToString());
                    }
                    Console.WriteLine("\n\n");
                }
                //Pytanie o zakres.
                Console.Write("Zakres: ");
                Zakres = 0;
                Zakres = short.Parse(Console.ReadLine());
            } while (Zakres != 0);
         }
    }
}