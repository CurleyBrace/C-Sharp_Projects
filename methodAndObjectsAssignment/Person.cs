using System;
using System.Collections.Generic;
using System.Text;

namespace methodAndObjectsAssignment
{
    public abstract class Person
    {
        public string FirstName { get; set; }               //Getting and setting FirstName
        public string LastName { get; set; }                //Getting and setting LastName

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);    //Printing First and Last name set in Class
        }
    }
}
