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

            IQuittable exEmployee = new Employee();     //Creating new IQuittable Object from our Interface
            exEmployee.Quit(employee);                  //Calling the quit method and sending it the object of Employee

            employee.SayName();                         //Calling SayName to print assigned values
            
            Console.ReadLine();
        }

    }
}
