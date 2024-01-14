using System;

namespace Lab3
{
    internal class DocumentaryBook : Book
    {
        //Pole z ilością stron książki
        public int iloscStron;

        //Konstruktok klasy DocumentaryBook
        public DocumentaryBook(string title, Person author, string dataWydania, int iloscStron) : base(title, author, dataWydania)
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
