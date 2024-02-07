using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_wewnetrzna
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista wewnętrzna na wzór listy TStringList
            //(z języka programowania Borland Delphi 2 i wyżej).
            //Copyright (c)by Jan T. Biernat
            ArrayList StringList = new ArrayList();
            StringList.Clear();
            StringList.Add("ZX Spectrum");
            StringList.Add("Commodore C64");
            StringList.Add("Atari 65XE");
            StringList.Add("Atari 130XE");
            StringList.Add("Atari ST");
            StringList.Add("Atari TT");
            StringList.Add("IBM");
            StringList.Add("CRY");
            StringList.Sort();
            for (int I = 0; I < StringList.Count; I++)
            {
                Console.WriteLine(StringList[I]);
            }
            //Naciśnij dowolny klawisz...
            Console.Write("\n\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}