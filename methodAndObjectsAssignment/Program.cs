using System;

namespace methodAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee employeeOne = new Employee();         //Creating new Employee Object
            Employee employeeTwo = new Employee();
            employeeOne.id = 01;                           //Setting each Employee's ID 
            employeeTwo.id = 02;

            bool idEquals = employeeOne == employeeTwo;    //Displaying use of the Operator

            Console.ReadLine();
        }

    }
}
