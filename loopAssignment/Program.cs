using System;

namespace loopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Yes";                                                       //Creating a string to command the while loop
            Random random = new System.Random();                                    //Creating a random object to allow for the game to be different each time
            
            while (String.Equals(x, "yes", StringComparison.OrdinalIgnoreCase))     //Start of the while loop for the game
            {
                int hiddenNumber = random.Next(1, 10);                              //Generating a random number between 1 and 100.
                int inputGuess = 0;

                do
                {
                    Console.WriteLine("Guess a number between 1 and 10.");          //Taking an input and converting it to an int to compare against hidden number
                    inputGuess = Convert.ToInt32(Console.ReadLine());
                }
                while (inputGuess != hiddenNumber);                                 //Do While Loop Condition. If the hidden number and the input number are not the same

                Console.WriteLine("Correct! The number was " + inputGuess);         //When you break the while loop, output congrats and ask if they'd like to play again
                Console.WriteLine("Would you like to play again? Yes or no.");      //Take input and assign it to the variable controlling the game while loop
                x = Console.ReadLine();
            }
            Console.WriteLine("Have a great day!");
            Console.ReadLine();
        }
    }
}
