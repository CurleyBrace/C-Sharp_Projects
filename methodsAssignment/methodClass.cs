using System;
using System.Collections.Generic;
using System.Text;

namespace methodsAssignment
{
    class methodClass
    {
        public int addNum(int userInput)            //Taking User Input and Adding 420 To it, then returning Sum
        {
            int sum = userInput + 420;
            return sum;
        }

        public double divideNum(int userInput)       //Taking User Input and dividing it by 420, then returning double quotient
        {

            double quotient = 420.0 / Convert.ToDouble(userInput);
            return quotient;
        }

        public int multiplyNum(int userInput)        //Taking User Input and multiplying it by 420, then returning product
        {
            int product = userInput * 420;
            return product;
        }
    }
}
