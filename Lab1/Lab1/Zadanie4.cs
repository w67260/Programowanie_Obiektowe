using System;

namespace Lab1
{
    internal class Zadanie4
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
            while (i > 0)//Dodanie elementów do tablicy
            {
                Console.Write($"Podaj liczbę nr {j}: ");
                array[k] = Convert.ToDouble(Console.ReadLine());
                j++;
                i--;
                k++;
            }
            Console.Clear();

            Console.Write("Twoja tablica:");
            for (i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Obliczanie sumy elementów tablicy
            Console.WriteLine("1. Suma elementów tablicy");
            double suma = 0;
            for (i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }
            Console.WriteLine("Suma = " + suma);
            Console.WriteLine();

            //Obliczanie iloczynu elementów tablicy
            Console.WriteLine("2. Iloczyn elementów tablicy");
            double iloczyn = 1;
            for (i = 0; i < array.Length; i++)
            {
                iloczyn *= array[i];
            }
            Console.WriteLine("Iloczyn = " + iloczyn);
            Console.WriteLine();

            //Obliczanie średniej elementów tablicy
            Console.WriteLine("3. Średnia elementów tablicy");
            double srednia = suma / (array.Length);
            Console.WriteLine("Średnia = "+srednia);
            Console.WriteLine();

            //Obliczanie wartości minimalnej tablicy
            double min = array[0];
            for(i= 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min= array[i];
                }
            }
            Console.WriteLine("3. Wartość minimalna tablicy = " + min);
            Console.WriteLine();

            //Obliczanie wartości maksymalnej tablicy
            double max = array[0];
            for (i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("4. Wartość maksymalna tablicy = " + max);
        }
    }
}
