using System;

namespace classSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass mathOp = new mathClass();                                 //Creating new mathClass
            int result;                                                         //Variable to take the output from mathClass

            Console.WriteLine("Please enter a number");                         //Asking for int from user
            int intInput = Convert.ToInt32(Console.ReadLine());

            mathOp.voidMethod(intInput, out result);                            //Sending first input and outputing the result to 'result'
            Console.WriteLine(result + " divided by 2 is " + result);

            Console.WriteLine("\nPlease a second number.");                      //Asking for int from user
            int intInputTwo = Convert.ToInt32(Console.ReadLine());

            mathOp.voidMethod(intInput, intInputTwo, out result);                //Sending both inputs and outputing the result to 'result'
            Console.WriteLine(intInput + " multiplied by " + intInputTwo + " is " + result);

            staticClass.text = "\nThis class is static. ";                       //Setting the value of text in staticClass
            Console.WriteLine(staticClass.text);                                 //Outputting from staticClass.Text
        }
    }
}
