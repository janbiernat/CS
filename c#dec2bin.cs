using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== Dec2Bin ==--
  Copyright (c)by Jan T. Biernat
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
namespace DziesNaDwoj
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
            int L = 0;
            Console.WriteLine("--== Dec2Bin ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat \n \n");
            //
            Console.Write("Liczba (DEC): ");
            L = int.Parse(Console.ReadLine());
            if(L < 1) { L = 1; }
            Console.Write("\n");
            Console.Write(L);
            Console.Write(" = ");
            Console.Write(dec2bin(L), "\n");
            //
            //Naciśnij dowolny klawisz.
            Console.Write("\n \nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}