using System;

namespace Lab6_3
{
    internal interface IPersonRepository
    {
        void AddPerson(Person person);
        List<Person> GetAllPersons();
    }
}
