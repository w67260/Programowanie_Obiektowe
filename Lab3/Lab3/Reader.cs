using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab3
{
    internal class Reader : Person
    {
        //Pole Book z książkami
        public List<Book> Book { get; set; }

        //Konstruktor klasy Reader
        public Reader(string FirstName, string LastName, int wiek, List<Book> Book) : base(FirstName, LastName, wiek)
        {
            this.Book = Book;
        }

        //Metoda dodająca książke do listy Book
        public void DodajKsiazke(Book x)
        {
            Book.Add(x);
        }

        //Metoda ViewBook Wypisująca przeczytane książki
        public void ViewBook()
        {
            Console.WriteLine("Przeczytane książki:");
            if (Book.Count > 0)
            {
                foreach (Book x in Book)
                {
                    Console.WriteLine(x.Title);
                }
            }
        }

        //Metoda View Wypisująca wszystkie dane
        public override void View()
        {
            base.View();
            ViewBook();
        }
    }
}
