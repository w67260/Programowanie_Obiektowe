using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie wpisując jego numer:");
            Console.WriteLine("1. Rozwiązanie równania kwadratowego");
            Console.WriteLine("2. Kalkulator");
            Console.WriteLine("3. Zadanie z tablicą");
            Console.WriteLine("4. Drugie zadanie z tablicą");
            Console.WriteLine("5. Wypisywanie liczb");
            Console.WriteLine("6. Nieskończona pętla");
            Console.WriteLine("7. Sortowanie liczb");
            double choice = new DoubleInputClass().DoubleInput();
            switch (choice){
                case 1:
                    //ZADANIE 1
                    new Zadanie1().SolveQuadraticEquation();
                    break;
                case 2:
                    //ZADANIE 2
                    new Zadanie2().Calculator();
                    break;
                case 3:
                    //ZADANIE 3
                    new Zadanie3().Array();
                    break;
                case 4:
                    //ZADANIE 4
                    new Zadanie4().Array();
                    break;
                case 5:
                    //ZADANIE 5
                    new Zadanie5().Display();
                    break;
                case 6:
                    //ZADANIE 6
                    new Zadanie6().Number();
                    break;
                case 7:
                    //ZADANIE 7
                    new Zadanie7().Sorting();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}