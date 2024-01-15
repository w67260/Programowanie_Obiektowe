using System;

namespace Lab4_2
{
    internal class Nauczyciel : Uczen
    {
        public string TytulNaukowy;
        public List<Uczen> PodwladniUczniowie= new List<Uczen>();

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine($"Lista uczniów, którzy mogą iść sami do domu w dniu {dateToCheck.ToShortDateString()}:");
            foreach (var uczen in PodwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome())
                {
                    Console.WriteLine(uczen.GetFullName());
                }
            }
        }
    }
}
