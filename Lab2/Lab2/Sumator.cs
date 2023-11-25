using System;

namespace Lab2
{
    internal class Sumator
    {
        //Pole Liczby
        private double[] Liczby = new double[] { };

        //Konstruktor z jednym parametrem
        public Sumator(double[] initialValue)
        {
            Liczby = initialValue;
        }

        //Metoda zwracająca liczbę elementów na w tablicy
        public int IleElementow()
        {
            return Liczby.Length;
        }

        //Metoda wypisująca wszystkie elementy tablicy
        public void WypiszLiczby()
        {
            Console.Write("Liczby: ");
            for (int i = 0; i < Liczby.Length; i++)
            {
                Console.Write(Liczby[i] + " ");
            }
            Console.WriteLine();
        }

        //Metoda Suma zwracająca sumę liczb z pola Liczby
        public double Suma()
        {
            double suma = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                suma += Liczby[i];
            }
            return suma;
        }

        //Metoda SumaPodziel2 zwracającą sumę liczb z tablicy, które są podzielne przez 2
        public double SumaPodziel2()
        {
            double suma = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                if (Liczby[i]%2 == 0)
                {
                    suma += Liczby[i];
                }
            }
            return suma;
        }

        //Metoda przyjmująca dwa parametry i wypisująca elementy o indeksach >= lowIndex oraz <= highIndex
        public void WypiszElementyWedlugZakresu(int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                Console.Write($"Elementy od indeksu {lowIndex} do indeksu {highIndex}: ");
                for (int i = lowIndex; i <= highIndex && i < Liczby.Length; i++)
                {
                    Console.Write(Liczby[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Błędne indeksy.");
            }
            
        }
    }
}
