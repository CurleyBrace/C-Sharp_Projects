using System;

namespace methodAssignmentP280
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass mathOp = new mathClass();                                                                                     //Calling mathClass for the functions
            int userInputOne = 0;
            int userInputTwo = 0;
            bool x = true;                                                                                                          //while loop boolean

            while (x == true)
            {
                try                                                                                                                 //Try statement to allow users to press enter without entering a number and continue through the program
                {
                    Console.WriteLine("\nEnter a number");
                    userInputOne = Convert.ToInt32(Console.ReadLine());                                                             //Taking first input
                    Console.WriteLine("\nEnter a second number if you'd like. Press enter to continue through the program.");      
                    userInputTwo = Convert.ToInt32(Console.ReadLine());                                                             //Taking second input
                    Console.WriteLine("\n" + userInputOne + " multiplied by " + userInputTwo + " is " + mathOp.multiply(userInputOne, userInputTwo));   //Attempting to print the product
                }
                catch (FormatException ex)                                                                                          //If no input is selected during the second, will fill secondNum with 5
                {
                    Console.WriteLine(userInputOne + " multiplied by 5 is " + mathOp.multiply(userInputOne));                       //Printing when only one value is input
                }
                finally
                {
                    Console.WriteLine("\nWould you like to go again? Yes/No ");                                                     //Requesting while loop input to repeat prog
                    string loopInput = Console.ReadLine();

                    x = String.Equals(loopInput, "yes", StringComparison.OrdinalIgnoreCase);                                        //Setting boolean for while loop based on input
                }
                
            }
        }
    }
}
