using System;

namespace Lab7
{
    internal class AddressBookManager
    {
        private AddressBook addressBook;
        private const string CsvFilePath = "addressbook.csv";

        public AddressBookManager()
        {
            addressBook = new AddressBook();
            addressBook.LoadFromCsv(CsvFilePath);
        }

        public void DisplayData()
        {
            List<Person> people = addressBook.GetPeople();

            foreach (var person in people)
            {
                Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, PESEL: {person.Pesel}, Email: {person.Email}");
            }
        }

        public void AddPerson()
        {
            Person newPerson = new Person();

            Console.Write("Podaj imię: ");
            newPerson.FirstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            newPerson.LastName = Console.ReadLine();

            Console.Write("Podaj ulicę: ");
            newPerson.Address = new Address
            {
                Street = Console.ReadLine()
            };

            Console.Write("Podaj miasto: ");
            newPerson.Address.City = Console.ReadLine();

            Console.Write("Podaj kod pocztowy: ");
            newPerson.Address.ZipCode = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.Write("Podaj PESEL (11 cyfr): ");
                    newPerson.Pesel = Console.ReadLine();

                    if (newPerson.Pesel.Length != 11)
                    {
                        throw new ArgumentException("PESEL musi składać się z 11 cyfr.");
                    }

                    Convert.ToInt64(newPerson.Pesel); // Sprawdzenie czy PESEL zawiera tylko cyfry.

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Podaj adres email: ");
                    newPerson.Email = Console.ReadLine();

                    if (!newPerson.Email.Contains("@"))
                    {
                        throw new ArgumentException("Nieprawidłowy format adresu email.");
                    }

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }

            List<Person> people = addressBook.GetPeople();
            people.Add(newPerson);

            Console.WriteLine("Osoba dodana do bazy.");
        }

        public void ModifyPerson()
        {
            Console.Write("Podaj PESEL osoby do modyfikacji: ");
            string peselToModify = Console.ReadLine();

            List<Person> people = addressBook.GetPeople();
            Person personToModify = people.Find(p => p.Pesel == peselToModify);

            if (personToModify != null)
            {
                Console.WriteLine($"Znaleziono osobę: {personToModify.FirstName} {personToModify.LastName}");

                Console.Write("Podaj nowe imię: ");
                personToModify.FirstName = Console.ReadLine();

                Console.Write("Podaj nowe nazwisko: ");
                personToModify.LastName = Console.ReadLine();

                Console.Write("Podaj nową ulicę: ");
                personToModify.Address.Street = Console.ReadLine();

                Console.Write("Podaj nowe miasto: ");
                personToModify.Address.City = Console.ReadLine();

                Console.Write("Podaj nowy kod pocztowy: ");
                personToModify.Address.ZipCode = Console.ReadLine();

                Console.WriteLine("Dane zaktualizowane.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono osoby o podanym PESEL.");
            }
        }

        public void RemovePerson()
        {
            Console.Write("Podaj PESEL osoby do usunięcia: ");
            string peselToRemove = Console.ReadLine();

            List<Person> people = addressBook.GetPeople();
            Person personToRemove = people.Find(p => p.Pesel == peselToRemove);

            if (personToRemove != null)
            {
                people.Remove(personToRemove);
                Console.WriteLine("Osoba usunięta z bazy.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono osoby o podanym PESEL.");
            }
        }

        public void SaveToCsv()
        {
            addressBook.SaveToCsv(CsvFilePath);
            Console.WriteLine("Zapisano zmiany do pliku CSV.");
        }
    }
}
