using System;

namespace methodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass mathOp = new mathClass();                     //Creating object MathOp

            mathOp.displayInt(numOne : 15, numTwo : 32);            //Calling MathOps' method to displayInt to multiply 15 times 12, and display the number 32

            Console.ReadLine();                                     //End Line for Program
        }
    }
}
