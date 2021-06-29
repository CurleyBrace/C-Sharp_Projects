using System;
using System.Text;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne = "Sara";                    //Creating Strings to Concatenate
            string nameTwo = "Jacobs";                  
            string nameThree = "Michael";               //Creating Strings to Concatenate
            string nameFour = "Johnson";                
            string nameFive = "Timothy";                //Creating Strings to Concatenate
            string nameSix = "Williams";

            string firstConc = nameOne +" "+ nameTwo;       //Concatenating The first two strings together
            string secondConc = nameThree +" "+ nameFour;   //Concatenating The second two strings together
            string thirdConc = nameFive +" "+ nameSix;      //Concatenating The third two strings together

            Console.WriteLine(firstConc);               //Printing the first concatenation
            Console.WriteLine(secondConc);              //Printing the first concatenation
            Console.WriteLine(thirdConc.ToUpper());               //Printing the first concatenation

            StringBuilder sb = new StringBuilder();     //Creating a StringBuilder object
            sb.AppendLine(nameOne + "'s last name is " + nameTwo + ". Their favorite food is pizza!");      //Appending three lines to this Stringbuilder using strings we've already created.
            sb.AppendLine(nameThree + "'s last name is " + nameFour + ". Their favorite food is pasta!");
            sb.AppendLine(nameFive + "'s last name is " + nameSix + ". Their favorite food is sushi!");
            sb.AppendLine(firstConc + " really enjoys going to the beach.");
            sb.AppendLine(secondConc + " really likes to stay home and play video games. ");
            sb.AppendLine(thirdConc + " loves to play sports with their friends. ");

            Console.WriteLine(sb);                      //Outputting the entire StringBuilder object
            Console.ReadLine();

        }
    }
}
