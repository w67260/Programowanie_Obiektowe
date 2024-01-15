using Lab2;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie wpisując jego numer:");
            Console.WriteLine("1. Zadanie 1");
            Console.WriteLine("2. Zadanie 2");
            Console.WriteLine("3. Zadanie 3");
            int choice = new IntInputClass().IntInput();

            switch (choice)
            {
                case 1:
                    //ZADANIE 1
                    Console.Write("Podaj numer albumu: ");
                    string x = Console.ReadLine();
                    using (var sw = new StreamWriter("nrAlbumu.txt"))
                    {
                        sw.WriteLine(x);
                    }
                    Console.WriteLine("Dane zapisano do pliku");
                    break;

                case 2:
                    //ZADANIE 2
                    try
                    {
                        using (var sr = new StreamReader("nrAlbumu.txt"))
                        {
                            var text = sr.ReadToEnd();
                            Console.WriteLine(text);
                        }
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Plik nrAlbumu.txt nie istnieje");
                    }
                    break;

                case 3:
                    //ZADANIE 3
                    List<string> pesels = new Pesel().ReadPeselsFromFile("pesels.txt");
                    int femaleCount = new Pesel().CountFemalePesels(pesels);

                    Console.WriteLine($"Liczba żeńskich Peseli: {femaleCount}");
                    break;
            }
        }
    }
}