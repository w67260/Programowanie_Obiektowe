using System;
using Newtonsoft.Json;

namespace Lab6_2
{
    internal class LoadPopulationDataClass
    {
        public List<PopulationData> LoadPopulationData(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<PopulationData>>(jsonContent);
        }
    }
}
