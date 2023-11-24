using System;

namespace Lab1
{
    internal class Zadanie6
    {
        public void Number()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Podaj liczbę: ");
                double a = new DoubleInputClass().DoubleInput();
                if (a < 0)
                {
                    break;
                }
            }
        }
    }
}
