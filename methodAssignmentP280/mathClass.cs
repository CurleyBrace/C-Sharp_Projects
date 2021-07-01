using System;
using System.Collections.Generic;
using System.Text;

namespace methodAssignmentP280
{
    class mathClass
    {
        public int multiply(int userInput, int extraInput = 5)      //Optional Input, will set to 5 if only one input is selected
        {
            int product = userInput * extraInput;
            return product;
        }
    }
}
