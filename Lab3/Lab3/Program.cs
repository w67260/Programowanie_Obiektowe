using Lab2;
using System.Collections.Generic;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie wpisując jego numer:");
            Console.WriteLine("1. Zadanie A");
            Console.WriteLine("2. Zadanie B");
            Console.WriteLine("3. Zadanie C");
            Console.WriteLine("4. Zadanie D");
            Console.WriteLine("5. Zadanie F");
            Console.WriteLine("6. Zadanie G");
            int choice = new IntInputClass().IntInput();

            //Utworzenie obiektów Person
            Person O1 = new Person("John Ronald Reuel", "Tolkien", 81);
            Person O2 = new Person("Andrzej", "Sapkowski", 75);
            Person O3 = new Person("Kacper", "Pitala", 30);

            //Utworzenie obiektów Book
            Book B1 = new Book("Hobbit, czyli tam i z powrotem", O1, "21.09.1937");
            Book B2 = new Book("Wiedźmin: Ostatnie życzenie", O2, "01.12.1993");
            Book B3 = new Book("Jak to wyjaśnić?", O3, "31.05.2021");

            List<Book> KM = new List<Book>();
            KM.Add(B1); KM.Add(B2); KM.Add(B3);
            List<Book> JK = new List<Book>();
            JK.Add(B1); JK.Add(B2);
            List<Book> ZN = new List<Book>();
            ZN.Add(B1);
            //Utowrzenie obiektów Reader
            Reader R1 = new Reader("Konrad", "Mrugała", 21, KM);
            Reader R2 = new Reader("Jan", "Kowalski", 35, JK);
            Person R3 = new Reader("Zbigniew", "Nowak", 25, ZN);

            List<Book> ON = new List<Book>();
            ON.Add(B1); ON.Add(B2); ON.Add(B3);
            List<Book> AK = new List<Book>();
            AK.Add(B1); AK.Add(B3);
            //Utowrzenie obiektów Reviewer
            Reviewer Re1 = new Reviewer("Oliwia", "Nowak", 46, ON);
            Reviewer Re2 = new Reviewer("Agata", "Kowalska", 58, AK);

            switch (choice)
            {
                case 1:
                    //ZADANIE 1A
                    Console.Clear();
                    O1.View();
                    O2.View();
                    B1.View();
                    B2.View();
                    break;

                case 2:
                    //ZADANIE 1B
                    Console.Clear();
                    
                    Console.WriteLine("Konrad Mrugała");
                    R1.ViewBook();
                    Console.WriteLine();
                    
                    Console.WriteLine("Jan Kowalski");
                    R2.ViewBook();
                    break;

                case 3:
                    //ZADANIE 1C
                    Console.Clear();
                    R1.View();
                    break;

                case 4:
                    //ZADANIE 1D
                    Console.Clear();
                    R3.View();
                    break;

                case 5:
                    //ZADANIE 1F
                    Console.Clear();
                    Re1.Wypisz();
                    Console.WriteLine();
                    Re2.Wypisz();
                    break;

                case 6:
                    //ZADANIE 1G
                    Console.Clear();
                    List<Person> Lista = new List<Person>();
                    Lista.Add(O1); Lista.Add(O2); Lista.Add(O3);
                    Lista.Add(R1); Lista.Add(R2); Lista.Add(R3);
                    Lista.Add(Re1); Lista.Add(Re2);
                    foreach (Person person in Lista)
                    {
                        person.View();
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}