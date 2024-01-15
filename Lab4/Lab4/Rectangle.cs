using System;

namespace Lab4
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Prostokąt o współrzędnych ({X}, {Y}) z wysokością {Height} i długością {Width}");
        }
    }
}
