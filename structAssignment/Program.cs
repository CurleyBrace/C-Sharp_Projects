using System;

namespace structAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numOne = new Number();           //Creating new Number numOne
            numOne.Amount = 5;                      //Setting the Number.Amount to 5

            Console.WriteLine(numOne.Amount);       //Displaying Number.Amount
            Console.ReadLine();
        }
    }
}
