using System;

namespace Lab4
{
    internal class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Trójkąt o współrzędnych ({X}, {Y}) z wysokością {Height} i długością {Width}");
        }
    }
}
