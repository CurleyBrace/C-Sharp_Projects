using System;

namespace dateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);                    //Printing current time

            Console.WriteLine("\nPlease enter a number. ");     //Asking for an input and converting it to integer
            int input = Convert.ToInt32(Console.ReadLine());

            DateTime inputTime = DateTime.Now.AddHours(input);  //Taking input and adding it to the current datetime in the hours parameter and then displaying
            Console.WriteLine(inputTime);
            
        }
    }
}
