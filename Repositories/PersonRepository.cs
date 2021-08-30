using System.Collections.Generic;
using WebApiPerson.Models;

namespace WebApiPerson.Repositories
{
    public class PersonRepository
    {
        private List<Person> listPerson = new List<Person>();

        public PersonRepository()
        {
            GetPeople();
        }
        public List<Person> GetAllPeople()
        {
            return listPerson;
        }

        public Person AddPerson(Person person)
        {
            listPerson.Add(new Person() { Name = person.Name, Age = person.Age });
            return person; ;
        }

        private List<Person> GetPeople()
        {
            listPerson.Add(new Models.Person() { Name = "Adolfo", Age = 36 });
            listPerson.Add(new Models.Person() { Name = "Andres", Age = 25 });
            listPerson.Add(new Models.Person() { Name = "Mayra", Age = 55 });
            listPerson.Add(new Models.Person() { Name = "Jennifer", Age = 15 });
            listPerson.Add(new Models.Person() { Name = "Luz", Age = 23 });

            return listPerson;
        }
    }
}
