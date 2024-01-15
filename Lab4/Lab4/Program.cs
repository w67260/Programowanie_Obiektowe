using Lab4;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle { X = 0, Y = 0, Height = 5, Width = 10 },
                new Triangle { X = 1, Y = 1, Height = 7, Width = 14 },
                new Circle { X = 2, Y = 2, Height = 6, Width = 6 }
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}