namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "db.json";
            List<PopulationData> populationData = new LoadPopulationDataClass().LoadPopulationData(jsonFilePath);

            Console.WriteLine("Różnica populacji Indii między 1970 a 2000 rokiem: " + new CalculatePopulationDifference().CalculatePopulation(populationData, "India", 1970, 2000));
            Console.WriteLine("Różnica populacji USA między 1965 a 2010 rokiem: " + new CalculatePopulationDifference().CalculatePopulation(populationData, "USA", 1965, 2010));
            Console.WriteLine("Różnica populacji Chin między 1980 a 2018 rokiem: " + new CalculatePopulationDifference().CalculatePopulation(populationData, "China", 1980, 2018));

            Console.WriteLine();

            Console.WriteLine("Wybierz rok i kraj, aby wyświetlić populację:");
            Console.Write("Podaj rok: ");
            int chosenYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj kraj (India, USA, China): ");
            string chosenCountry = Console.ReadLine();

            new DisplayPopulation().DisplayPopulationForYearAndCountry(populationData, chosenYear, chosenCountry);

            Console.WriteLine("\nPodaj zakres lat i kraj, aby sprawdzić różnicę populacji:");
            Console.Write("Podaj początkowy rok: ");
            int startYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj końcowy rok: ");
            int endYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj kraj (India, USA, China): ");
            string selectedCountry = Console.ReadLine();

            Console.WriteLine($"Różnica populacji między {startYear} a {endYear} rokiem dla {selectedCountry}: " + new CalculatePopulationDifference().CalculatePopulation(populationData, selectedCountry, startYear, endYear));

            Console.WriteLine("\nPodaj rok, aby sprawdzić procentowy wzrost populacji dla każdego kraju:");
            Console.Write("Podaj rok: ");
            int growthYear = Convert.ToInt32(Console.ReadLine());
            new DisplayPopulation().DisplayPopulationGrowthPercentage(populationData, growthYear);
        }
    }
}