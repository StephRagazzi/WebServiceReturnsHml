using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService2.Models;

namespace WebService2.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        //public IEnumerable<Person> Get()
        public Person Get()
        {
            Person person1 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Hobbies = new List<string> { "Basket-Ball", "Music", "Soccer" }
            };

            return person1;

        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }

        private static IEnumerable<Person> CreatePersons()
        {
            Person person1 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Hobbies = new List<string> { "Basket-Ball", "Music", "Soccer" }
            };

            Person person2 = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 31,
                Hobbies = new List<string> { "Tennis", "Running" }
            };

            Person person3 = new Person
            {
                FirstName = "Johnny",
                LastName = "Doe",
                Age = 32,
                Hobbies = new List<string> { "Tennis", "Running" }
            };

            List<Person> persons = new List<Person> 
            { 
                person1,
                person2,
                person3
            };
            return persons;
        }

    }
}
