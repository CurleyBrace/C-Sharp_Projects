using System;
using System.Collections.Generic;
using System.Text;

namespace classSubmissionAssignment
{
    class mathClass
    {
        public void voidMethod(int input, out int result)                   //First Void Method, outputs an int and divides by 2
        {
            result = input / 2;                                             
        }

        public void outPutParam(out int divNum, out int result)             //Method with output parameters
        {
            divNum = 5;                                             
            result = 10;
        }

        public void voidMethod(int inputOne, int inputTwo, out int result)   //Overloaded method
        {
            result = inputOne * inputTwo;                                    //Multiplying the two inputs and assigning the output to the result
        }
    }

    public static class staticClass                                           //Static class
    {
        public static string text;                                            //Giving the static class a value so that we can display it when it changes
    }
}
