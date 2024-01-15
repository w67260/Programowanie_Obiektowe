using System;

namespace Lab4
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Koło o współrzędnych ({X}, {Y}) z wysokością {Height} i długością {Width}");
        }
    }
}
