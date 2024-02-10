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
 Przeliczanie z systemu liczbowego dziesiętnego (DEC)
 na system liczbowy dwójkowy (BIN):
    173 : 2 ; reszta ; 1
     86 : 2 ; reszta ; 0
     43 : 2 ; reszta ; 1
     21 : 2 ; reszta ; 1
     10 : 2 ; reszta ; 0
      5 : 2 ; reszta ; 1
      2 : 2 ; reszta ; 0
      1 : 2 ; reszta ; 1
    Wynik: 1010 1101 <- Wynik odczytujemy od dołu do góry.
*/
namespace ascii2
{
    class Program
    {
        static string ZeraPrzedLiczba(string Str, int Ile)
        {
            //ZeraPrzedLiczba - Funkcja dodaje na początku zera wiodące.
            string Zera = "";
            if (Ile > Str.Length)
            {
                for (int I = 0; I < (Ile - Str.Length); I++) { Zera += '0'; }
                return Zera + Str;
            }
            else { return Str; }
        }
        static string BinFormat(string Str = "")
        {
            //BinFormat - Funkcja formatuje liczbę w systemie binarnym (np. 11111111 => 1111 1111).
            short Licznik = 0;
            string Znaki = "";
            if (Str.Trim() != "")
            {
                for (int I = Str.Length - 1; I > -1; I--)
                {
                    Znaki = Str[I] + Znaki;
                    Licznik++;
                    if (Licznik > 3)
                    {
                        Licznik = 0;
                        Znaki = ' ' + Znaki;
                    }
                }
                return Znaki.Trim();
            } else { return ""; }
        }
        static string Dec2Bin(long Liczba = 0)
        {
            //Dec2Bin - Konwersja liczby dziesiętnej na liczbę dwójkową. 
            long Wynik = 0;
            int Licznik = 0; 
            string Tablica = "", Rezultat = "";
            //Wykonaj konwersję liczby dziesiętnej na liczbę dwójkową. 
            if (Liczba > 0)
            {
                do
                {
                    Wynik = 0; Wynik = Liczba / 2;
                    if (Liczba % 2 != 0) { Tablica = Tablica + "1"; }
                    else { Tablica = Tablica + "0"; }
                    Liczba = 0; Liczba = Wynik;
                    Licznik++;
                } while (Wynik != 0);
                //Wyświetl wynik pobierając liczby z tablicy od tyłu. 
                for (int I = Licznik - 1; I > -1; I--) { Rezultat+= Tablica[I]; }
                return ZeraPrzedLiczba(Rezultat, 8);
            }
            else { return "0"; }
        }
        //Blok główny (startowy).
        static void Main(string[] args)
        {
            Console.WriteLine("--== Tablica ASCII w konsoli w2 ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat\n");
            for (int I = 32; I < 127; I++)
            {
                Console.Write("\n ");
                if (I == 32) { Console.Write(" SPC | "); }
                else { Console.Write("  "+(char)I+"  | "); }
                if (I < 100) { Console.Write(" "); }
                Console.Write(I.ToString());
                Console.Write(" | "+I.ToString("X2")+" | ");
                Console.Write(BinFormat(Dec2Bin(I)));
            }
            //Naciśnij dowolny klawisz...
            Console.Write("\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}