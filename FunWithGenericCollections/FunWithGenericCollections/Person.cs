using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(int age, string firstname, string lastname)
        {
            this.Age = age;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public Person() { }

        public override string ToString()
        {
            return ($"My Name is {FirstName} {LastName} and my age is {Age}");
        }


    }
}
