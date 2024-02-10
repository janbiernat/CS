using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== Tablica ASCII w konsoli ==--
  Copyright (c)by Jan T. Biernat
 =
 Tablica kodów ASCII (ang. American Standard Code for Information
 Interchange) stanowi zestaw kodów używanych do reprezentacji znaków
 (liter, cyfr, znaków specjalnych np. @, $, # itp.).
 Każdy znak w tabeli ma przyporządkowaną wartość liczbową dziesiętną,
 np. litera duża "A"  ma wartość dziesiętną 65.
 Tablica ASCII składa się 255 znaków, które podzielone są na kilka grup:
   > Od 0 do 31 - znaki sterujące np. klawiszem ENTER, TAB, drukarką;
   > Od 32 do 126 - znaki podstawowe;
   > Od 127 do 255 - znaki dodatkowe (zawierają znaki graficzne,
                     oraz znaki polskie itp.).
 Podstawowa tabela ASCII (tj. od 0 do 127) nie podlega wymianie,
 natomiast rozszerzona tablica (tj. od 128 do 255) może ulegać zmianie
 np. w celu zakodowania polskich znaków.
*/
namespace ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--== Tablica ASCII w konsoli ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat\n");
            for (int I = 32; I < 127; I++)
            {
                Console.Write("\n ");
                if (I == 32) { Console.Write(" SPC | "); }
                else { Console.Write("  " + (char)I + "  | "); }
                if (I < 100) { Console.Write(" "); }
                Console.Write(I.ToString());
                Console.Write(" | " + I.ToString("X2"));
            }
            //Naciśnij dowolny klawisz...
            Console.Write("\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}