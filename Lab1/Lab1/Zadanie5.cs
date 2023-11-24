using System;

namespace Lab1
{
    internal class Zadanie5
    {
        public void Display()
        {
            Console.Clear();

            Console.WriteLine("Wypisane liczby:");
            int[] array = new int[] { 2, 6, 9, 15, 19 };
            for (int i = 20; i > 0; i--)
            {
                if (array.Contains(i)){
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
