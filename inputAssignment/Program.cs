using System;
using System.IO;

namespace inputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int input = Convert.ToInt32(Console.ReadLine());                                        //Requesting an input from the user

            using (StreamWriter text = new StreamWriter(@"C:\Users\Tommy\Desktop\Text.txt", true))  //Creating a new streamwriter and assiging the directory
            {
                text.WriteLine(input);                                                              //Writing the user input to the directory specified above
            }

            string textFile = File.ReadAllText(@"C:\Users\Tommy\Desktop\text.txt");                 //Assigning the contents of this file to textFile String
            Console.WriteLine(textFile);                                                            //Printing the variable declared above
            Console.ReadLine();
        }
    }
}
