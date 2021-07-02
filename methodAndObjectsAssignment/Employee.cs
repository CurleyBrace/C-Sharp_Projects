using System;
using System.Collections.Generic;
using System.Text;

namespace methodAndObjectsAssignment
{
    public class Employee : Person, IQuittable          //Inheriting from Person
    {

        public void Quit(Person person)         //Calling the method Quit from IQuittable with the Parameters sent from Program.cs
        {
            Console.WriteLine("Thank you for working with us " + person.FirstName + " " + person.LastName + ".");
        }
    }
}
