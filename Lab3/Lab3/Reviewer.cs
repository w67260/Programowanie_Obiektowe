using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab3
{
    internal class Reviewer : Reader
    {
        //Pole z losową liczbą
        private Random random;

        //Konstruktor klasy Reviewer
        public Reviewer(string FirstName, string LastName, int wiek, List<Book> Book) : base(FirstName, LastName, wiek, Book)
        {
            random = new Random();
        }

        //Metoda Wypisz wypisująca dane
        public void Wypisz()
        {
            base.View();
            Console.WriteLine("Recenzja:");
            foreach (Book book in Book)
            {
                int rating = random.Next(1, 6); // Losowa ocena od 1 do 5
                Console.WriteLine($"{book.Title}: {rating}/5");
            }

        }
    }
}
