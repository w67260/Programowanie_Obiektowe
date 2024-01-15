using System;

namespace Lab5
{
	internal class Length
	{
        public static void PrintLength(string input)
        {
            try
            {
                if (input == null)
                {
                    throw new ArgumentNullException("input", "Przekazany parametr nie może być null.");
                }

                int length = input.Length;
                Console.WriteLine("Długość napisu: " + length);
            }
            catch (Exception ex)
            {
                throw new Exception("Wystąpił błąd przy obliczaniu długości napisu.", ex);
            }
        }
    }
}
