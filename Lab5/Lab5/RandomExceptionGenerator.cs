using System;

namespace Lab5
{
    internal class RandomExceptionGenerator
    {
        public static void ThrowRandomException()
        {
            Random random = new Random();
            int randomValue = random.Next(1, 4);

            switch (randomValue)
            {
                case 1:
                    throw new CustomException1("To jest CustomException1.");
                case 2:
                    throw new CustomException2("To jest CustomException2.");
                case 3:
                    throw new CustomException3("To jest CustomException3.");
                default:
                    throw new Exception("Nieznany wyjątek.");
            }
        }
    }
}
