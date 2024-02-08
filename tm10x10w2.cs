using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm10x10w2
{
    class Program
    {
        /*--== Tabliczka mnożenia (10x10) w2 ==--
          Copyright (c)by Jan T. Biernat
         */
        static string JustujDoPrawej(string Str = "", int IleMaks = 0)
        {
            //JustujDoPrawej - Dodaj znaki puste (tzw. znaki spacji) przed podanym ciągiem znaków.
            string _T = "";
            if((Str.Trim() != "") && (IleMaks > Str.Length))
            {
                for(int I = 0; I < (IleMaks-Str.Length); I++) { _T += " "; }
            }
            return _T+Str.Trim();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--== Tabliczka mnożenia (10x10) w2 ==--\n");
            Console.Write("  ");
            for(int I = 0; I < 10; I++)
            {
                Console.Write(JustujDoPrawej((I+1).ToString(), 4));
            }
            for(int A = 0; A < 10; A++)
            {
                Console.WriteLine();
                Console.Write (JustujDoPrawej((A+1).ToString(), 2));
                for (int B = 0; B < 10; B++)
                {
                    Console.Write(JustujDoPrawej(((A+1)*(B+1)).ToString(), 4));
                }
            }
            //Naciśnij dowolny klawisz...
            Console.Write("\n\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}