using System;

namespace Lab7
{
    internal class AddressBook
    {
        private List<Person> people = new List<Person>();

        public void LoadFromCsv(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');

                    Person person = new Person
                    {
                        FirstName = parts[0],
                        LastName = parts[1],
                        Address = new Address
                        {
                            Street = parts[2],
                            City = parts[3],
                            ZipCode = parts[4]
                        },
                        Pesel = parts[5],
                        Email = parts[6]
                    };

                    people.Add(person);
                }
            }
        }

        public void SaveToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var person in people)
                {
                    string line = $"{person.FirstName},{person.LastName},{person.Address.Street},{person.Address.City},{person.Address.ZipCode},{person.Pesel},{person.Email}";
                    writer.WriteLine(line);
                }
            }
        }

        public List<Person> GetPeople()
        {
            return people;
        }
    }
}
