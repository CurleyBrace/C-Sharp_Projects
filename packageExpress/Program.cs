using System;

namespace packageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;                                                                              //Creating a boolean for the while loop
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");  
            while (x == true)                                                                           //Start of While Loop to repeat program
            {
                Console.WriteLine("What is the package weight? ");
                double weight = Convert.ToDouble(Console.ReadLine());                                   //Requesting Package weight and converting it to a double

                if (weight > 50.0)                                                                      //If weight is greater than 50, exit the loop
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    break;
                }

                Console.WriteLine("What is the package width?");                                        //Taking package width as a double
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package height?");                                       //Taking package height as a double
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");                                       //Taking package length as a double
                double length = Convert.ToDouble(Console.ReadLine());

                if ((height + length + width) > 50.0)                                                   //If sum of dimensions is greater than 50, exit the loop
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    break;
                }

                double quote = ((height * width * length) * weight) / 100;                              //Determining the $$ based on dimensions provided and displaying them
                Console.WriteLine("Your total for shipping this package is: " + quote);
                Console.WriteLine("Would you like to ship another package? Please enter Yes or No.");   //Requesting input to enter another package or end the loop
                string repeatProg = Console.ReadLine();
                x = String.Equals(repeatProg, "Yes", StringComparison.OrdinalIgnoreCase);

            }
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}

