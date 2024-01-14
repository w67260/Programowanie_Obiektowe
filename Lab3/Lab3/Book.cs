using System;

namespace Lab3
{
    internal class Book
    {
        //Pola z tytuł, autor i data wydania
        protected string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        protected Person author;
        public string Author
        {
            get { return Author; }
            set { Author = value; }
        }
        protected string dataWydania;
        public string DataWydania
        {
            get { return DataWydania; }
            set { DataWydania = value; }
        }

        //Konstruktor klasy Book
        public Book(string title, Person author, string dataWydania)
        {
            this.title = title;
            this.author = author;
            this.dataWydania = dataWydania;
        }

        //Metoda View wypisująca dane
        public virtual void View()
        {
            Console.WriteLine("Tytuł: " + title);
            Console.WriteLine("Autor: " + author);
            Console.WriteLine("Data Wydania: " + dataWydania);
        }
    }
}
