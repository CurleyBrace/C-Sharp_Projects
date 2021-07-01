using System;
using System.Collections.Generic;
using System.Text;

namespace mainMethodAssignment
{
    class mathClass
    {
        public int math(int userInput)
        {
            int product = userInput * 15;                   //Will take an int and retun the input multiplied by 15
            return product;
        }

        public int math(decimal userInput)
        {
            decimal divide = userInput / 15;               //Will take a decimal and retun the input divided by 15
            int divideInt = Convert.ToInt32(divide);
            return divideInt;
        }

        public int math(string userInput)
        {
            int userNum = Convert.ToInt32(userInput);     //Will take a string and return the input multiplied by itsself
            int squared = userNum * userNum;
            return squared; 
        }
    }
}
