using System;

namespace Lab3
{
    internal class AdventureBook : Book
    {
        //Pole z ilością stron książki
        public int iloscStron { get; set; }

        //Konstruktok klasy AdventureBook
        public AdventureBook(string title, Person author, string dataWydania, int iloscStron) : base(title, author, dataWydania)
        {
            this.iloscStron = iloscStron;
        }

        //Metoda View wypisująca dane
        public override void View()
        {
            base.View();
            Console.WriteLine("Ilość stron: " + iloscStron);
        }
    }
}
