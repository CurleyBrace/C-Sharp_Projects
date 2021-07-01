using System;

namespace methodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            methodClass mathMethod = new methodClass(); //Creating a new object of class methodClass
            bool x = true;                              //While Loop Boolean

            while (x == true)                           //Start of While Loop
            {
                try
                {
                    Console.WriteLine("Please enter a number to add, divide and multiply by our pre-set number.");
                    int userInput = Convert.ToInt32(Console.ReadLine());    //Taking user input and converting to int

                    Console.WriteLine("Your number added to our number is: " + mathMethod.addNum(userInput)); //Sending userinput and calling addSum Method
                    Console.WriteLine("Your number divided into our number is: " + mathMethod.divideNum(userInput));  //Sending userinput and calling divideSum Method
                    Console.WriteLine("Your number multiplied by our number is: " + mathMethod.multiplyNum(userInput)); //Sending userinput and calling multiplySum Method
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You cannot divide by Zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    Console.WriteLine("\nWould you like to do another number? Yes/No");        //Requesting input for While Loop
                    string loopInput = Console.ReadLine();

                    x = String.Equals(loopInput, "Yes", StringComparison.OrdinalIgnoreCase); //Reading input and setting While Boolean accordingly
                }
            }
        }
    }
}
