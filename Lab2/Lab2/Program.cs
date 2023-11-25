using Lab1;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie wpisując jego numer:");
            Console.WriteLine("1. Klasa Licz");
            Console.WriteLine("2. Sumator");
            Console.WriteLine("3. Data");
            Console.WriteLine("4. Liczba, wypisywanie jej, mnożenie oraz silnia");
            double choice = new DoubleInputClass().DoubleInput();
            switch (choice)
            {
                case 1:
                    //ZADANIE 1
                    Licz obiekt1 = new Licz(13);
                    Licz obiekt2 = new Licz(9);

                    //Wypisanie stanu obiektów
                    Console.Write("Obiekt 1: ");
                    obiekt1.WypiszStan();
                    Console.Write("Obiekt 2: ");
                    obiekt2.WypiszStan();

                    //Działanie: obiekt1 + 5
                    obiekt1.Dodaj(5);
                    Console.Write("Obiekt 1 po dodaniu 5: ");
                    obiekt1.WypiszStan();

                    //Działanie: obiekt2 - 4
                    obiekt2.Odejmij(4);
                    Console.Write("Obiekt 2 po odjęciu 4: ");
                    obiekt2.WypiszStan();
                    break;
                case 2:
                    //ZADANIE 2
                    Console.Clear();
                    double[] liczby = { 2, 2.5, 3, 4, 5.5, 6 };
                    Sumator sumator = new Sumator(liczby);

                    //Wypisywanie elementów
                    sumator.WypiszLiczby();

                    //Ilość elementów
                    int ilosc = sumator.IleElementow();
                    Console.WriteLine("Ilość elementów w tablicy: " + ilosc);

                    //Suma liczb
                    double suma = sumator.Suma();
                    Console.WriteLine("Suma liczb: " + suma);

                    //Suma liczb podzielnych przez 2
                    double sumaPodziel2 = sumator.SumaPodziel2();
                    Console.WriteLine("Suma liczb podzielnych przez 2: " + sumaPodziel2);

                    //Elementy o indeksach >= lowIndex oraz <= highIndex
                    Console.Write("Podaj mniejszy indeks: ");
                    int lowIndex = new IntInputClass().IntInput();
                    Console.Write("Podaj większy indeks: ");
                    int highIndex = new IntInputClass().IntInput();
                    sumator.WypiszElementyWedlugZakresu(lowIndex, highIndex);
                    break;
                case 3:
                    //ZADANIE 3
                    Console.Clear();
                    Data Data = new Data();
                    //Bierząca data
                    DateTime bierzacaData = Data.BiezacaData();
                    Console.WriteLine("Bierząca data to: " + bierzacaData);

                    //Data tydzień w przód
                    Data.DataWstecz();
                    DateTime dataWstecz = Data.BiezacaData();
                    Console.WriteLine("Data tydzien wstecz to: " + dataWstecz);

                    //Data tydzień w tył
                    Data.DataWprzod();
                    Data.DataWprzod();
                    DateTime dataWprzod = Data.BiezacaData();
                    Console.WriteLine("Data tydzien wprzód to: " + dataWprzod);
                    break;
                case 4:
                    //ZADANIE 4
                    Console.Clear();
                    //Pobranie liczby
                    Console.Write("Podaj liczbę: ");
                    string number = Console.ReadLine();

                    Console.Clear();
                    Liczba Liczba = new Liczba(number);

                    //Wypisanie liczby
                    Liczba.Wypisz();

                    //Przemnażanie przez podaną liczbę
                    Liczba.Mnozenie();

                    //Silnia z podanym parametrem
                    Console.Write("Podaj liczbę do silni: ");
                    int initialValue = new IntInputClass().IntInput();
                    Liczba.Silnia(initialValue);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}