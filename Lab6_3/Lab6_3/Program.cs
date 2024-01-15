namespace Lab6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "persons.json";
            IPersonRepository personRepository = new PersonRepository(filePath);

            Person newPerson = new Person("Jan", "Kowalski");
            personRepository.AddPerson(newPerson);

            List<Person> allPersons = personRepository.GetAllPersons();

            foreach (var person in allPersons)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            }
        }
    }
}