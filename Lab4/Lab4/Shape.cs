﻿using System;

namespace Lab4
{
    internal class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape");
        }
    }
}
