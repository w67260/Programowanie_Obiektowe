using System;

namespace Lab4_3
{
    internal static class RozszerzeniaOsob
    {
        //Metoda wypisujaca osoby z listy
        public static void WypiszOsoby(this List<IOsoba> listaOsob)
        {
            foreach (var osoba in listaOsob)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }

        //Metoda sotrująca osoby w liscie
        public static void PosortujOsobyPoNazwisku(this List<IOsoba> listaOsob)
        {
            listaOsob.Sort((o1, o2) => o1.Nazwisko.CompareTo(o2.Nazwisko));
        }
    }
}
