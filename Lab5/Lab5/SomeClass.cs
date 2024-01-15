using System;

namespace Lab5
{
    internal class SomeClass
    {
        public void CanThrowException()
        {
            if (new Random().Next(5) == 0)
                throw new Exception();
        }
    }
}
