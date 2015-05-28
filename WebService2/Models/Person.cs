using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Telephone { get; set; }
        public IList<string> Hobbies { get; set; }
    }
}