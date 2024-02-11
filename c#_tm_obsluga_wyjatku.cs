using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmAxB_obsluga_wyjatku
{
    class Program
    {
        /*--== Tabliczka mnożenia (X*X) - Obsługa wyjątku ==--
          Copyright (c)by Jan T. Biernat
         */
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
        //Blok główny (startowy).
        static void Main(string[] args)
        {
            const string Koniec = "koniec";
            string Zakres = "";
            short LZakres = 0;
            do
            {
                Console.Clear();
                //Generuj tabliczkę mnożenia X*X.
                if ((Zakres.Trim() != "") && (Zakres.ToLower() != Koniec.ToLower())
                    && (LZakres > 0))
                {
                    if(LZakres > 24) { LZakres = 24; } //Zabezpieczenie: Tabliczka mnożenia nie może być większa niż 24x24.
                    Console.Write("  ");
                    for (int I = 0; I < LZakres; I++)
                    {
                        Console.Write(JustujDoPrawej((I + 1).ToString(), 4));
                    }
                    for (int A = 0; A < LZakres; A++)
                    {
                        Console.WriteLine();
                        Console.Write(JustujDoPrawej((A + 1).ToString(), 2));
                        for (int B = 0; B < LZakres; B++)
                        {
                            Console.Write(JustujDoPrawej(((A + 1) * (B + 1)).ToString(), 4));
                        }
                    }
                    Console.WriteLine("\n");
                }
                //Pobierz dane dotyczące zakresu od użytkownika.
                Console.Write("Zakres: ");
                Zakres = Console.ReadLine();
                LZakres = 0;
                try { LZakres = short.Parse(Zakres); }
                catch
                {
                    //Tu wpisz kod do obsługi wyjątku.
                }
            } while (Zakres.ToLower() != Koniec.ToLower());
        }
    }
}