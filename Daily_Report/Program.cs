using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report"); //Intro to program

            Console.WriteLine("What is your name?"); //Asking for and taking input of Student Name
            string studentName = Console.ReadLine(); //Taking Input and Assigning to to studentName

            Console.WriteLine("What course are you on?"); //Asking for and taking input of Student Name
            string studentCourse = Console.ReadLine(); //Taking Input and Assigning to to studentCourse

            Console.WriteLine("What page number?"); //Asking for and taking input of Student Name
            byte pageNum = Convert.ToByte(Console.ReadLine()); //Taking input and converting to a byte and assigning the name pageNum

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\""); //Asking for and taking input of Student Name
            Boolean studentHelp = Convert.ToBoolean(Console.ReadLine()); //Taking input and converting to a Boolean and assigning the name studentHelp

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //Asking for and taking input of Student Name
            string studentExperience = Console.ReadLine(); //Taking Input and Assigning to to studentExperience

            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific."); //Asking for and taking input of Student Name
            string studentFeedback = Console.ReadLine(); //Taking Input and Assigning to to studentFeedback

            Console.WriteLine("How many hours did you study today?"); //Asking for and taking input of Student Name
            float studentHours = float.Parse(Console.ReadLine()); //Taking input and converting to a float and assigning the name studentHours

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.\nHave a great day!"); //Exit from Program
            Console.ReadLine(); //Catch to stop the program from closing at end.
        }
    }
}
