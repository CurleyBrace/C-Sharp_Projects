using System;
using System.Collections.Generic;
using System.Text;

namespace methodAndObjectsAssignment
{
    interface IQuittable            //Creating an interface IQuittable to allow the Employee to always quit
    {
        void Quit(Person person);                //Determining the Method that must be implemented
    }
}
