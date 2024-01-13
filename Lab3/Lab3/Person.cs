using System;

namespace Lab3
{
    internal class Person
    {
        //Pola z imie, nazwisko i wiek
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int wiek { get; set; }

        //Konstruktor klasy Person
        public Person(string FirstName, string LastName, int wiek)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.wiek = wiek;
        }

        //Metoda View wypisująca dane
        public virtual void View()
        {
            Console.WriteLine("Imie: " + FirstName);
            Console.WriteLine("Nazwisko: " + LastName);
            Console.WriteLine("Wiek: " + wiek);
        }
    }
}
