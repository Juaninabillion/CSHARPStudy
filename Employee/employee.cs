using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        // constructors

        public Employee() { }

        public Employee(string name, int id, int age,float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;

        }

        // this is a property encapsulating the empName field
        public string Name
        {
            get { return empName; }

            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Name is too large");
                else { empName = value; }
            }

        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }


        public void GiveBonus (float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine(" Name: {0}", empName);
            Console.WriteLine(" ID: {0}", empID);
            Console.WriteLine(" Pay: {0}", currPay);

        }
        
        public void SetName(string name)
        {
            empName = name;
        }
        public string GetName()
        {
            return empName;
        }
        

    }
}
