using System;

namespace Lab6_2
{
    internal class DisplayPopulation
    {
        public void DisplayPopulationForYearAndCountry(List<PopulationData> data, int year, string country)
        {
            var populationData = FindPopulationData(data, country, year);
            Console.WriteLine($"Populacja {country} w roku {year}: " + (populationData != null ? populationData.Value : "Brak danych"));
        }

        public void DisplayPopulationGrowthPercentage(List<PopulationData> data, int year)
        {
            var countries = new List<string> { "India", "USA", "China" };

            foreach (var country in countries)
            {
                var currentYearData = FindPopulationData(data, country, year);
                var previousYearData = FindPopulationData(data, country, year - 1);

                double currentPopulation = currentYearData != null ? double.Parse(currentYearData.Value) : 0;
                double previousPopulation = previousYearData != null ? double.Parse(previousYearData.Value) : 0;

                double growthPercentage = ((currentPopulation - previousPopulation) / previousPopulation) * 100;

                Console.WriteLine($"Wzrost populacji dla {country} w roku {year}: {growthPercentage}%");
            }
        }

        private PopulationData FindPopulationData(List<PopulationData> data, string country, int year)
        {
            foreach (var item in data)
            {
                if (item.Country.Value == country && item.Date == year.ToString())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
