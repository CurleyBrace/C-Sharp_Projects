using System;
using System.Threading;

namespace tryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool loopVar = true;
            bool validInput = false;
            DateTime timeNow = DateTime.Now;


            while (loopVar == true)
            {
                try
                {
                    Console.WriteLine("Please enter your age.");
                    validInput = int.TryParse(Console.ReadLine(), out age);             //Taking an input and checking it for validation
                    if (!validInput) throw new Exception();                             //If it is not a valid input, throw exception
                    if (age == 0) throw new FormatException();                          //If it is 0, throw format exception
                    if (age < 0) throw new ArgumentOutOfRangeException();               //if it is negative, throw outofrange exception

                    int birthYear = (timeNow.Year - age);                               //declaring birthyear to be year.now - input
                    Console.WriteLine("You were born in the year " + birthYear + ". ");
                    Console.ReadLine();                                                 //displaying this to user
                    loopVar = false;                                                    //while loop boolean, allowing the program to end
                }

                catch (FormatException ex)                                              //catching the first exception for entering 0
                {
                    Console.WriteLine("You cannot be 0 years old. Please enter a valid age.");
                }
                catch (ArgumentOutOfRangeException ex)                                  //catching the second exception for entering negative numbers
                {
                    Console.WriteLine("You cannot be negative years old. Please enter a valid age.");
                }
                catch (Exception)                                                       //catching any other exceptions
                {
                    Console.WriteLine("Please make sure you're only entering positive whole numbers.");
                }
            }
        }
    }
}
