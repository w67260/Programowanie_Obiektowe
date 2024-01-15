using System;

namespace Lab4_3
{
    internal class Student : IStudent
    {
        //Pola klasy Student
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        //Metoda zwracająca pełną nazwę
        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }

        //Metoda zwracająca pełną zazwe oraz uczelnie
        public void WypiszPelnaNazweIUczelnie()
        {
            string nazwa = ZwrocPelnaNazwe();
            Console.WriteLine(nazwa);
            Console.WriteLine(Uczelnia + " " + Kierunek + " " + Rok + " " + Semestr);

        }
    }
}
