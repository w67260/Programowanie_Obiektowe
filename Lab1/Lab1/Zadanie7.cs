using System;

namespace Lab1
{
    internal class Zadanie7
    {
        public void Sorting()
        {
            Console.Clear();
            Console.Write("Podaj ilość liczb do posortowania: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            //Pobieranie liczb
            for(int i = 0; i < n; i++)
            {
                Console.Write("Podaj liczbę: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Twoje liczby:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //Wybór metody sortowania
            Console.WriteLine("Wybierz metodę sortowania:");
            Console.WriteLine("1. Sortowanie bąbelkowe");
            Console.WriteLine("2. Sortowanie przez wstawianie");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BubbleSort(array);
                    Console.WriteLine("Posortowane elementy:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    break;

                case 2:
                    InsertionSort(array);
                    Console.WriteLine("Posortowane elementy:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }

        //Sortowanie bąblekowe
        static void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //Sortowanie przez wstawianie
        static void InsertionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }
        }
    }
}