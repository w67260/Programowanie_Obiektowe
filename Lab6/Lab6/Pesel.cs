using System;

namespace Lab6
{
    internal class Pesel
    {
        //Metoda wczytująca Pesele z pliku tekstowego
        public List<string> ReadPeselsFromFile(string fileName)
        {
            List<string> pesels = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        pesels.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Plik {fileName} nie istnieje.");
            }
            return pesels;
        }

        //MEtoda zliczająca ilość żeńskich Peseli
        public int CountFemalePesels(List<string> pesels)
        {
            int femalePesels = 0;

            foreach (string pesel in pesels)
            {
                if (IsFemalePesel(pesel))
                {
                    femalePesels++;
                }
            }

            return femalePesels;
        }

        //Metoda sprawdzająca, czy pesel dotyczy osoby płci żeńskiej
        public bool IsFemalePesel(string pesel)
        {
            int genderDigit = int.Parse(pesel.Substring(9, 1));
            return genderDigit % 2 == 0;
        }
    }
}
