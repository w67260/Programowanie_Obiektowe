using System;

namespace Lab2
{
    internal class Licz
    {
        //Pole przechowujące wartość liczbową
        private double value;

        //Konstruktor bez parametrów
        public Licz() { }

        //Konstruktor z jednym parametrem
        public Licz(double initialValue)
        {
            value = initialValue;
        }

        //Metoda dodająca przekazaną wartość do wartości trzymanej w polu value
        public void Dodaj(double arg)
        {
            value += arg;
        }

        //Metoda odejmująca przekazaną wartość od wartości trzymanej w polu value
        public void Odejmij(double arg)
        {
            value -= arg;
        }

        //Metoda wypisująca stan obiektu
        public void WypiszStan()
        {
            Console.WriteLine(value);
        }
    }
}
