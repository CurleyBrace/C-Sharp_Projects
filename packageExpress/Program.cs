using System;

namespace packageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");
            while (x == true)
            {
                Console.WriteLine("What is the package weight? ");
                double weight = Convert.ToDouble(Console.ReadLine());

                if (weight > 50.0)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }

                Console.WriteLine("What is the package width?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                double length = Convert.ToDouble(Console.ReadLine());

                if ((height + length + width) > 50.0)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }

                double quote = ((height * width * length) * weight) / 100;
                Console.WriteLine("Your total for shipping this package is: " + quote);
                Console.WriteLine("Would you like to ship another package? Please enter Yes or No.");
                string repeatProg = Console.ReadLine();
                x = String.Equals(repeatProg, "Yes", StringComparison.OrdinalIgnoreCase);

            }
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}

