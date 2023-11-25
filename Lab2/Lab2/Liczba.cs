using System;
using System.Security.Cryptography;

namespace Lab2
{
    internal class Liczba
    {
        //Składowa number
        private int[] number;

        //Konstruktor z jednym parametrem typu string
        public Liczba(string initialValue)
        {
            number = new int[initialValue.Length];
            for (int i = 0; i < initialValue.Length; i++)
            {
                number[i] = Convert.ToInt32(initialValue[i].ToString());
            }
        }

        //Metoda wypisująca liczbę
        public void Wypisz()
        {
            Console.Write("Twoja liczba to: ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }

        //Metoda przemnażająca przez podaną liczbę
        public void Mnozenie()
        {
            //Pobranie mnożnika
            Console.Write("Przez jaka liczbę przemnożyć? Podaj ją: ");
            int mnoznik = Convert.ToInt32(Console.ReadLine());

            //Pobranie liczby z tablicy
            string textNumber = "";
            for (int i = 0; i < number.Length; i++)
            {
                textNumber += number[i].ToString();
            }
            int digitalNumber = Convert.ToInt32(textNumber);

            //Działanie
            int result = digitalNumber * mnoznik;
            Console.WriteLine("Wynik mnożenia to: " +  result);

            if (result.ToString().Length != number.Length)
            {
                int[] newNumber = new int[result.ToString().Length];
                for(int i = 0; i < newNumber.Length; i++)
                {
                    newNumber[i] = result.ToString()[i];
                }
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = result.ToString()[i];
                }
            }
        }

        //Metoda silnia
        public void Silnia(int initialValue)
        {
            int result = 1;
            int save = initialValue;
            while (initialValue > 0)
            {
                result *= initialValue;
                initialValue--;
            }
            Console.WriteLine($"Silnia z liczby {save} to: {result}");
        }
    }
}
