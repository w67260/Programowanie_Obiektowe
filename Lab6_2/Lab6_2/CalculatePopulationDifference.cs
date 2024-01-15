using System;

namespace Lab6_2
{
    internal class CalculatePopulationDifference
    {
        public int CalculatePopulation(List<PopulationData> data, string country, int startYear, int endYear)
        {
            var startYearData = FindPopulationData(data, country, startYear);
            var endYearData = FindPopulationData(data, country, endYear);

            int startPopulation = startYearData != null ? int.Parse(startYearData.Value) : 0;
            int endPopulation = endYearData != null ? int.Parse(endYearData.Value) : 0;

            return endPopulation - startPopulation;
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
