using System;
using System.Collections.Generic;
using System.Text;

namespace methodAndObjectsAssignment
{
    public class Employee : Person, IQuittable          //Inheriting from Person
    {
        public int id { get; set; }                     //Assigning a property to Employee as ID


                    //Returning a value of true if the id's of Employee are the ==
        public static bool operator == (Employee employee1, Employee employee2) 
        {
            if (employee1.id == employee2.id)
            {
                Console.WriteLine("This id has already been used.");
                return true;
            } 
            else
            {
                Console.WriteLine("This id has not been used.");
                return false;
            }
        }
                    //Returning a value of true if the id's of Employee are the !=, required for the above operator
        public static bool operator != (Employee employee1, Employee employee2) 
        {
            if (employee1.id == employee2.id)
            {
                Console.WriteLine("This id has already been used.");
                return true;
            }
            else
            {
                Console.WriteLine("This id has not been used.");
                return false;
            }
        }

        public void Quit(Person person)         //Calling the method Quit from IQuittable with the Parameters sent from Program.cs
        {
            Console.WriteLine("Thank you for working with us " + person.FirstName + " " + person.LastName + ".");
        }
    }
}
