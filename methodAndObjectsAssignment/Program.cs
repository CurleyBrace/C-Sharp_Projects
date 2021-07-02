using System;

namespace methodAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();         //Creating new Employee Object
            employee.FirstName = "Sample";              //Setting Employee Values for FirstName
            employee.LastName = "Student";              //Setting Employee Values for LastName

            employee.SayName();                         //Calling SayName to print assigned values
            
            Console.ReadLine();
        }

    }
}
