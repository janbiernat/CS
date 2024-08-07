using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//--== Przypominaj o ważnych wydarzeniach ==--
//Copyright (c)by Jan T. Biernat
namespace ConsoleApp
{
    class Program
    {
        static void Przypomnij(string Dane = "")
        {
            DateTime teraz = DateTime.Now;
            string DataMD = ""; DataMD = teraz.ToString("MM-dd");
            string DataM = ""; DataM = teraz.ToString("MM");
            string DataD = ""; DataD = teraz.ToString("dd");
            string DataN = ""; DataN = teraz.ToString("ddd");
            string DaneM = "", DaneD = "", DaneI = "";
            if(Dane.Trim() != "")
            {
                DaneM = Dane.Substring(0, 2);
                DaneD = Dane.Substring(3, 2);
                DaneI = Dane.Substring(5);
                if ((DaneM+"-"+DaneD == DataMD)
                || (DaneM + "-" + DaneD == DataM+"---")
                || (DaneM + "-" + DaneD == "---"+DataD)
                || (DaneM + "-" + DaneD == DataM + "-" + DataN.Substring(0, 2).ToLower())
                || (DaneM + "-" + DaneD == "---" + DataN.Substring(0,2).ToLower())
                || (DaneM + "-" + DaneD == "-----")) { Console.WriteLine(DaneI.Trim()); }
            }
            else { Console.WriteLine("BŁĄD -?Brak danych!"); }
        }
        //
        static void Main(string[] args)
        {
            Console.WriteLine("--== Przypominaj o ważnych wydarzeniach ==--");
            Console.WriteLine("Copyright (c)by Jan T. Biernat\n\n");
            //
            //Deklaracja zmiennych.
            String Data = "";
            String Linia = "";
            //
            //Odczytanie daty systemowej.
            DateTime teraz = DateTime.Now;
            Data = ""; Data = teraz.ToString("yyyy-MM-dd");
            Console.WriteLine(Data);
            Console.WriteLine(teraz.ToString("dddd, dd MMMM yyyy")+"r.\n");
            //
            //Odczyt pliku tekstowego.
            StreamReader PlikTekstowy = new StreamReader("przypomnij.txt");
            while (Linia != null)
            {
                Linia = PlikTekstowy.ReadLine();
                Przypomnij(Linia);
            }
            PlikTekstowy.Close();
            //
            //Czekaj, aż użytkownik naciśnie dowolny klawisz.
            Console.Write("\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
/*
Legenda:
DateTime teraz = DateTime.Now;
Utworzenie obiektu/zmiennej o nazwie "teraz" na podstawie klasy DateTime.
Od tego momentu obiekt/zmienna "teraz" posiada informacje o bieżącej dacie i czasie.
-
StreamReader PlikTekstowy = new StreamReader("przypomnij.txt");
Utworzenie obiektu/zmiennej "PlikTekstowy" i przypisanie do niej nazwy
pliku tekstowego "przypomnij.txt" lub ścieżki dostępu wraz z nazwą pliku tekstowego.
-
while (Linia != null)
Pętla while jest wykonywana tak długo, dopóki odczyt pliku tekstowego
nie osiągnie końca.
-
Linia = PlikTekstowy.ReadLine();
Odczyt pojedynczego wiersza z pliku tekstowego i przypisanie odczytanych danych
do zmiennej "Linia".
=
Klasa to typ zdefiniowany przez użytkownika lub struktura danych zadeklarowana
      za pomocą dowolnego słowa kluczowego class, struct lub union, której
      składowymi są dane i funkcje, których dostęp jest regulowany przez
      trzy specyfikatory dostępu: prywatny, chroniony lub publiczny.
*/