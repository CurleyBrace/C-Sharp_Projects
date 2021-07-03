using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace lambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Joe", "Jeff", "Thomas", "Joe", "Jimmie", "Sarah", "Michelle", "Amber", "Jay", "Brenda" }; //Pre-determined List of names to add
            List<Employee> employeeList = new List<Employee>();            //List of Employee Objects
            int i = 1;                                                  //ID Counter

            foreach (string name in nameList)                           //Adding the list above to the Employee List
            {
                Employee tempEmployee = new Employee();                 //Creating a temp Employee
                tempEmployee.FirstName = name;
                tempEmployee.ID = i;

                employeeList.Add(tempEmployee);                            //Filling in the List of Employees with tempEmployee
                i++;
            }
 
            List<Employee> tempList = new List<Employee>();             //Temp List to pull everyone named Joe

            foreach(Employee employee in employeeList)                     //Loop Statement to find everyone named Joe
            {
                if (employee.FirstName == "Joe")
                {
                    tempList.Add(employee);                             //Adding to TempList
                }
            }

            List<Employee> employeeListTwo = new List<Employee>();              //Creating a second List for the Lamba expression
            employeeListTwo = employeeList.FindAll(x => x.FirstName == "Joe");  //Using lamba expression to do the same thing as above

            List<Employee> employeeOverFive = new List<Employee>();         
            employeeOverFive = employeeList.FindAll(x => x.ID > 5);             //Using lamba expression to do the add everyone who's ID is over 5


            Console.WriteLine("There are " + employeeListTwo.Count() + " employees named 'Joe'.");
            Console.WriteLine("There are " + employeeOverFive.Count() + " employees with an ID number greater than five.\n");
            
            foreach (Employee employee in employeeOverFive)                     //Checking that the second Lamba function works
            {
                Console.WriteLine(employee.FirstName);
            }

        }
    }
}
