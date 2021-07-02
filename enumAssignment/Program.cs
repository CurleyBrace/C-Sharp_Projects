using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace enumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;                                                                                                          //While Loop Boolean
            Days userDay = new Days();                                                                                              //Creating a new Days object

            while (x == true)
            {
                try
                {
                    Console.WriteLine("\nPlease enter the current day of the week.");                                               //Prompting the user for input for a string
                    string userInput = Console.ReadLine();

                    userDay.Today = String.Equals(userInput, "sunday", StringComparison.OrdinalIgnoreCase) ? Day.Sunday :           //Ternary Statement to assign variable based on the string entered above
                                    String.Equals(userInput, "monday", StringComparison.OrdinalIgnoreCase) ? Day.Monday :           //Each day is determined by a single statement and assigned from the enum
                                    String.Equals(userInput, "tuesday", StringComparison.OrdinalIgnoreCase) ? Day.Tuesday :
                                    String.Equals(userInput, "wednesday", StringComparison.OrdinalIgnoreCase) ? Day.Wednesday :
                                    String.Equals(userInput, "thursday", StringComparison.OrdinalIgnoreCase) ? Day.Thursday :
                                    String.Equals(userInput, "friday", StringComparison.OrdinalIgnoreCase) ? Day.Friday :
                                    String.Equals(userInput, "saturday", StringComparison.OrdinalIgnoreCase) ? Day.Sunday :
                                        throw new Exception();
                    x = false;                                                                                                      //Setting the while loop boolean to false
                }
                catch (Exception ex)                                                                                                //Catching the exception from the ternary above
                {
                    Console.WriteLine("Please enter an actual day of the week.");                                                   //Telling the user there was an error with what they entered
                }  
            }
            Console.WriteLine("Today is: " + userDay.Today);                                                                        //Closing statement for the program
            Console.WriteLine("Thank you for using my program!");
            Console.ReadLine();
        }
    }
}
