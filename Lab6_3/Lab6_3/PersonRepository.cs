using System;
using Newtonsoft.Json;

namespace Lab6_3
{
    internal class PersonRepository : IPersonRepository
    {
        private string filePath { get; }

        public PersonRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public void AddPerson(Person person)
        {
            var persons = GetAllPersons();
            persons.Add(person);

            SavePersonsToFile(persons);
        }

        public List<Person> GetAllPersons()
        {
            if (!File.Exists(filePath))
            {
                return new List<Person>();
            }

            var jsonContent = File.ReadAllText(filePath);
            var persons = JsonConvert.DeserializeObject<List<Person>>(jsonContent);
            return persons ?? new List<Person>();
        }

        private void SavePersonsToFile(List<Person> persons)
        {
            var jsonContent = JsonConvert.SerializeObject(persons, Formatting.Indented);
            File.WriteAllText(filePath, jsonContent);
        }
    }
}
