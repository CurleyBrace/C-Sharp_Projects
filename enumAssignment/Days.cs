using System;
using System.Collections.Generic;
using System.Text;

namespace enumAssignment
{
    public class Days                                                   //Creating the Object Days
    {
        public Day Today { get; set; }                                  //Allowing the value of Today to be initialized

    }

    public enum Day                                                     //Creating the parameters for how the program may initialize the value Today
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
