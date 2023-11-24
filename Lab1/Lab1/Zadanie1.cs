using System;

namespace Lab1
{
    internal class Zadanie1
    {
        public void SolveQuadraticEquation()
        {
            Console.Clear();

            //Pobranie współczynników
            Console.Write("Podaj współczynnik a: ");
            double a = new DoubleInputClass().DoubleInput();
            Console.Write("Podaj współczynnik b: ");
            double b = new DoubleInputClass().DoubleInput();
            Console.Write("Podaj współczynnik c: ");
            double c = new DoubleInputClass().DoubleInput();

            double delta = b * b - 4 * a * c;

            if (delta > 0) // Obliczenie delty
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Delta: " + delta);
                Console.WriteLine("Pierwiastki: x1 = " + x1 + ", x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("Delta: " + delta);
                Console.WriteLine("Pierwiastek podwójny: x1 = " + x1);
            }
            else
            {
                Console.WriteLine("Delta jest ujemna, brak pierwiastków rzeczywistych.");
            }
        }
    }
}