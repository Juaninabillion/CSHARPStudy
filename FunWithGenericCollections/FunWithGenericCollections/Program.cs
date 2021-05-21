using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSortedSet();
        }

        static void UserSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName = "Homer", LastName = "simpson", Age = 47},
                new Person {FirstName = "Homer", LastName = "simpson", Age = 45},
                new Person {FirstName = "Homer", LastName = "simpson", Age = 9},
                new Person {FirstName = "Homer", LastName = "simpson", Age = 8 }
            };

            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }

        public static void UseDictionary()
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();

            peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleA.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleA.Add("Lisa", new Person { FirstName = "List", LastName = "Simpson", Age = 9 });

            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);

            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                {"Homer",new Person{FirstName = "Homer",LastName = "Simpson",Age = 47} },
                {"Marge", new Person {FirstName = "Marge", LastName = "Simpson",Age = 45}},
                {"Lisa", new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
            };
            // get lisa
            Person Lisa = peopleB["Lisa"];
            Console.WriteLine(Lisa);
        }
            }
            
        }
    }
}
