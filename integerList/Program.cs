using System;
using System.Collections.Generic;

namespace integerList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;                                                                                          //While loop boolean

            while (x == true)                                                                                       //Start of while loop
            {
                Random listGen = new Random();                                                                      //Generater for the Random Numbers
                List<int> intList = new List<int>();                                                                //List to hold the numbers generated
                try                                                                                                 //Begin of the Try Statement
                {
                    Console.WriteLine("Please enter a number to divide the List's contents by.");                   //Taking an input of divided number
                    int divNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("How many numbers would you like to divide by your selected number?");        //Taking an input for number of values to display
                    int listLen = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < listLen; i++)                                                               //For loop to create and divide each number and display them
                    {
                        intList.Add(listGen.Next(0, 1000));
                        Console.WriteLine((i + 1) + ". " + intList[i] + " divided by " + divNum + " is " + intList[i] / divNum + ".");
                    }
                }
                catch (DivideByZeroException ex)                                                                    //Divide by Zero catch
                {
                    Console.WriteLine("You cannot divide by Zero.");
                }
                catch (Exception ex)                                                                                //Any other exceptions Catch
                {   
                    Console.WriteLine(ex);
                }
                finally                                                                                             //Ask to repeat the program
                {
                    Console.WriteLine("\nWould you like to go through this program again?");                        //Taking input for yes/no to repeat
                    string repInput = Console.ReadLine();

                    x = String.Equals(repInput, "yes", StringComparison.OrdinalIgnoreCase);                         //Comparing to "yes", if yes X will remain true and program will repeat
                }
            }
            Console.ReadLine();
        }
    }
}
