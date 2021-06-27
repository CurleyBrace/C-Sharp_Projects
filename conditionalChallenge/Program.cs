using System;

namespace conditionalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100:");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input < 24)
            {
                Console.WriteLine("Your number is less than 24.");
            } else if (input > 24 && input < 50) 
            {
                Console.WriteLine("Your number is greater than 24 but less than 50.");
            } else
            {
                Console.WriteLine("Your number is 50 or greater.");
            }
        }
    }
}
