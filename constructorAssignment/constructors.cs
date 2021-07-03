using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace constructorAssignment
{
    public class constructors
    {
        public string firstName;                            //Creating two variables to pass through the constructors
        public string lastName;


        public constructors() : this("Sample", "Student")   //Creating the first constructor. Will auto fill with Sample, Student
        {
            Console.WriteLine("First Constructor");
        }
        public constructors(string firstName, string lastName)  //Second constructor, will take parameters given and assign firstName
        { 
            this.firstName = firstName;
            Console.WriteLine("Second Constructor");
        }
    }
}
