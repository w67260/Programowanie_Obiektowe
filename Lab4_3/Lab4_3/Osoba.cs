using System;

namespace Lab4_3
{
    internal class Osoba : IOsoba
    {
        //Pola Imie i Nazwisko
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        //Metoda zwracająca pełną nazwę
        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
