using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== Tablica ASCII w konsoli w2 ==--
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
 =
 Przeliczanie z systemu liczbowego dziesiętnego (DEC)
 na system liczbowy dwójkowy (BIN):
 Przykład 1: 10 = 1010
    10 : 2 =  5.0 ; reszta ; 0
     5 : 2 =  2.5 ; reszta ; 1
     2 : 2 =  1.0 ; reszta ; 0
     1 : 2 =  0.5 ; reszta ; 1

     Wynik: 1010 <- Wynik odczytujemy od dołu do góry.

 Przykład 2: 15 = 1111
    15 : 2 = 7.5 ; reszta 1
     7 : 2 = 3.5 ; reszta 1
     3 : 2 = 1.5 ; reszta 1
     1 : 2 = 0.5 ; reszta 1

  Przykład 3: 25 = 1 1001
     25 : 2 = 12.5 ; reszta 1
     12 : 2 =  6.0 ; reszta 0
      6 : 2 =  3.0 ; reszta 0
      3 : 2 =  1.5 ; reszta 1
      1 : 2 =  0.5 ; reszta 1

  Przykład 4: 173 = 1010 1101
     173 : 2 = 86.5 ; reszta ; 1
      86 : 2 = 43.0 ; reszta ; 0
      43 : 2 = 21.5 ; reszta ; 1
      21 : 2 = 10.5 ; reszta ; 1
      10 : 2 =  5.0 ; reszta ; 0
       5 : 2 =  2.5 ; reszta ; 1
       2 : 2 =  1.0 ; reszta ; 0
       1 : 2 =  0.5 ; reszta ; 1
*/
namespace ascii2
{
    class Program
    {
        //dec2bin - Funkcja konwertująca liczbę z systemu dziesiętnego na dwójkowy.
        static string dec2bin(long L = 0)
        {
            int S = 0;
            string B = "";
            if (L < 1) { L = 1; }
            while (L > 0)
            {
                if (S > 3) { B = ' ' + B; S = 0; }
                S++;
                if (L % 2 == 0) { B = '0' + B; } else { B = '1' + B; }
                L /= 2; //Zapis "L /= 2;" jest równoważny z zapisem "L = L/2;".
            }
            return B;
        }
        //
        //Blok główny (startowy).
        static void Main(string[] args)
        {
            Console.WriteLine("--== Tablica ASCII w konsoli w2 ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat \n \n");
            //
            Console.Write(" Znak | Kod | Hex | Bin \n");
            for(int I = 0; I < 30; I++) { Console.Write("-");  }
            for (int I = 32; I < 127; I++)
            {
                Console.Write("\n ");
                if (I == 32) { Console.Write(" SPC | "); }
                else { Console.Write("  " + (char)I + "  | "); }
                if (I < 100) { Console.Write(" "); }
                Console.Write(I.ToString());
                Console.Write(" |  " + I.ToString("X2") + " | ");
                Console.Write(dec2bin(I));
            }
            //
            //Naciśnij dowolny klawisz...
            Console.Write("\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}