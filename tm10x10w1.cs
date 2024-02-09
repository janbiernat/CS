using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm10x10w1
{
    class Program
    {
        /*--== Tabliczka mnożenia (10x10) w1 ==--
          Copyright (c)by Jan T. Biernat
         */
        static void Main(string[] args)
        {
            Console.WriteLine("--== Tabliczka mnożenia (10x10) w1 ==--\n");
            Console.Write("    ");
            for (int I = 1; I < 11; I++)
            {
                if(I < 10) { Console.Write(" "); }
                Console.Write(I.ToString()+"  ");
            }
            for (int A = 1; A < 11; A++)
            {
                Console.WriteLine();
                if (A < 10) { Console.Write(" "); }
                Console.Write(A.ToString());
                for (int B = 1; B < 11; B++)
                {
                    if((A*B) < 10) { Console.Write("  "); }
                    else if ((A*B) < 100) { Console.Write(" "); }
                    Console.Write(" "+(A*B).ToString());
                }
            }
            //Naciśnij dowolny klawisz...
            Console.Write("\n\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}