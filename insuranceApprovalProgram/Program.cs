using System;

namespace insuranceApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());                                                      //Taking input for age and converting to int
            Console.WriteLine("Have you ever had a DUI? Please enter Yes or No.");
            string duiInput = Console.ReadLine();                                                               //Taking input for DUI, specifying in output to say yes or no
            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());                                                  //Taking input for tickets and converting to int

            if (age > 15 && String.Equals(duiInput, "No", StringComparison.OrdinalIgnoreCase) && tickets <= 3)  //Determining the Output based on the 3 conditions(one of the conditions uses an operator to compare regardless of case)
            {
                Console.WriteLine("You are qualified.");                                                        //Qualified Output
            } else
            {
                Console.WriteLine("You are not qualified.");                                                    //Not Qualified Output
            }
        }
    }
}
