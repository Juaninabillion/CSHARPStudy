using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        //is the car alive or dead?
        private bool carIsDead;

        //class constructors
        public Car() { }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        //define a delegate type
        public delegate void CarEgineHandler(string msgForCaller);

        //define a member variable of this delegate;
        // we make this member private to enforce encapsulation
        // the helper method RegisterWithCarEngine will allow outside calls to queue methods into its invocation list
        private CarEgineHandler listOfHandlers;

        // by adding the +=, we are allowing this listOfHandlers delegate to become a multicast delegate
        // meaning that we can now add multiple methods to the invocation list. 
        // Delegate.Combine ==  '+=' operator
        public void RegisterWithCarEngine(CarEgineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        // same thing with the Unregister helper. 
        // Here we use -= to remove a method from the invocation list of the listOfHandlers delegate
        public void UnRegisterWithCarEngine(CarEgineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            // If this car is dead
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry, this car is dead");
                }
            }
            else
            {
                CurrentSpeed += delta;

                //Is this car " almost dead"
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Carefull buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }

        }
    }
}
    

