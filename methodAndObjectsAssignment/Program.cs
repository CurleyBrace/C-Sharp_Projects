using System;
using System.Collections.Generic;
using System.Text;

namespace methodAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employeeOne = new Employee<string>();       //Creating new Employee Object with DataType String
            List<string> workExp = new List<string> { "Clerk", "Butcher", "Programmer" }; //Creating Temp List to add to Employee Object
            employeeOne.things = workExp;

            Employee<int> employeeTwo = new Employee<int>();            //Creating new Employee Object with DataType String
            List<int> yearsWorked = new List<int> { 5, 2, 9 };          //Temp List to add to EmployeeTwo
            employeeTwo.things = yearsWorked;

            foreach (string thing in employeeOne.things)                //For Each loop to go through List with data type String and print each one
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employeeTwo.things)                   //For Each loop to go through List with data type Int and print each one
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }

    }
}
