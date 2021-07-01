using System;

namespace mainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass mathOp = new mathClass();                             //Creating new object mathOp

            Console.WriteLine("Please enter an number.");                   //Asking and taking an input, converting to an int
            int userInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathOp.math(userInt));                        //Calling MathOp to perform the math function with the int parameter

            Console.WriteLine("\nPlease enter a number.");                  //Asking and taking an input, converting to an decimal
            decimal userDec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(mathOp.math(userDec));                        //Calling MathOp to perform the math function with the decimal parameter

            Console.WriteLine("\nPlease enter a number.");                  //Asking and taking an input
            string userStr = Console.ReadLine();
            Console.WriteLine(mathOp.math(userStr));                        //Calling MathOp to perform the math function with the string parameter
        }
    }
}
