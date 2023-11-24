using System;

namespace Lab1
{
    internal class Zadanie3
    {
        public void Array()
        {
            Console.Clear();

            double[] array = new double[10];//utworzenie tablicy 10 elemetowej
            DoubleInputClass input = new DoubleInputClass();
            Console.WriteLine("Podaj 10 liczb.");
            int i = 10;
            int j = 1;
            int k = 0;
            while(i > 0)//Dodanie elementów do tablicy
            {
                Console.Write($"Podaj liczbę nr {j}: ");
                array[k] = Convert.ToDouble(Console.ReadLine());
                j++;
                i--;
                k++;
            }

            Console.Clear();

            //Wyświetlenie tablicy od pierwszego do ostatniego elementu
            Console.WriteLine("1. Wyświetlenie tablicy od pierwszego do ostatniego elementu");
            for (i=0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Wyświetlenie tablicy od ostatniego do pierwszego elementu
            Console.WriteLine("2. Wyświetlenie tablicy od ostatniego do pierwszego elementu");
            for (i = 9; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Wyświetlanie elementów o nieparzystych indeksach
            Console.WriteLine("3. Wyświetlanie elementów o nieparzystych indeksach");
            for (i = 1; i < array.Length; i+=2)
            {
                Console.WriteLine($"array[{i}] = " + array[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Wyświetlanie elementów o parzystych indeksach
            Console.WriteLine("3. Wyświetlanie elementów o parzystych indeksach");
            for (i = 0; i < array.Length; i+=2)
            {
                Console.WriteLine($"array[{i}] = " + array[i]);
            }
        }
    }
}
