using System;

namespace mathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to multiply: ");               //Asking for an Input for the Multiplication Operator Example
            double multiInput = Convert.ToDouble(Console.ReadLine());               //Taking an input and converting it to a usable datatype with the name multiInput
            Console.WriteLine("Your product is: "+ 50.0 * multiInput);              //Using the multiplication operator and printing the result

            Console.WriteLine("Please enter a number to add: ");                    //Asking for an Input for the Addition Operator Example
            double sumInput = Convert.ToDouble(Console.ReadLine());                 //Taking an input and converting it to a usable datatype with the name sumInput
            Console.WriteLine("Your sum is: " + (25.0 + sumInput));                 //Using the addition operator and printing the result

            Console.WriteLine("Please enter a number to divide: ");                 //Asking for an Input for the Divide Operator Example
            double divideInput = Convert.ToDouble(Console.ReadLine());              //Taking an input and converting it to a usable datatype with the name divideInput
            Console.WriteLine("Your product is: " + divideInput/12.5);              //Using the division operator and printing the result

            Console.WriteLine("Please enter a number to compare: ");                //Asking for an Input for the Boolean Operator Example
            double compareInput = Convert.ToDouble(Console.ReadLine());             //Taking an input and converting it to a usable datatype with the name compareInput
            bool compareOutput = compareInput > 50.0;                               //Comparing the input and the number '50' and applying the result to the boolean compareOutput
            Console.WriteLine("Is your number greater than 50? " + compareOutput);  //Printing the result of the boolean comparison

            Console.WriteLine("Please enter a number to find the remainder of: ");  //Asking for an Input for the Modulus Operator Example 
            double remainInput = Convert.ToDouble(Console.ReadLine());              //Taking an input and converting it to a usable datatype with the name remainInput
            Console.WriteLine("Your remainder is: "+ remainInput%7.0);              //Using the modulus operator and printing the result
        }
    }
}
