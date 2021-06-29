using System;
using System.Collections.Generic;


namespace arrayAssignment
{
    class Program
    {
        //These are the pre-determined arrays that will allow the user to select from
        public string[] stringArray = new string[10] { "Amber", "Barbara", "Bennett", "Diona", "Jean", "Lisa", "Michael", "Sarah", "Thomas", "William" };
        public int[] intArray = new int[10] {2, 356, 4302, 6774, 9438, 10213, 14049, 19320, 21304, 22504};
        public List<string> stringList = new List<string>() { "This", "is", "A", "String", "List", "Full", "of", "Strings", "To", "Display" };
        public static bool breakString = false;


        static void Main(string[] args)
        {
            bool x = true;                                                                                   //This is a Boolean that controls the while loop that repeats the program
            int displayInput = 0;                                                                            //This is the input variable to determine the index of the displayed array/list
            string sameArray = "no";
                                                                                                             //Text Prompting the user with instructions
            Console.WriteLine("Welcome. There are three different examples of Array/Lists for you to search through.");
            Console.WriteLine("You may enter 0-9 to to display and of their held values when prompted.");
            Console.WriteLine("There is a feature in which you are able to go back through and select variables multiple times per index.");
            Console.WriteLine("If you'd like to turn off extra prompts, type \"Break\" anytime you are prompted to go back through an array.");


            while (x == true)                                                                                //Loop to allow the user to go back through the string array if they want
            {
                Console.WriteLine("\nOf the String Array, which index would you like to display?");          //Asking for an index and converting it to int
                displayInput = Convert.ToInt32(Console.ReadLine());

                arrayPrint(displayInput, 0);                                                                 //Sending the input and a value of 0 to determine the string type based on pre-set parameters
                if (Program.breakString != true) { x = loopArrays(); }                                       //Asking the user if they'd like to repeat the array and returning the value
            }

            x = true;                                                                                        //Resetting the While Loop Boolean
            if (Program.breakString != true) { sameArray = keepIndex(); }

            while (x == true)                                                                                //Loop to allow the user to go back through the string array if they want
            {
                if (String.Equals(sameArray, "no", StringComparison.OrdinalIgnoreCase))                      //If they wanted to input a different index, prompts the user 
                {
                    Console.WriteLine("\nOf the Integer Array, which index would you like to display?");     //Asking for an index and converting it to int
                    displayInput = Convert.ToInt32(Console.ReadLine());                                                                      
                }
                sameArray = "no";                                                                            //Changing Same Array to No so that if you decide to continue entering numbers it will loop through the previous if statement.

                arrayPrint(displayInput, 1);                                                                 //Sending the input and a value of 1 to determine the string type based on pre-set parameters
                if (Program.breakString != true) { x = loopArrays(); }                                       //Asking the user if they'd like to repeat the array and returning the value
                else { x = false; }
            }

            x = true;                                                                                        //Resetting the While Loop Boolean
            if (Program.breakString != true) { sameArray = keepIndex(); }

            while (x == true)                                                                                //Loop to allow the user to go back through the string array if they want
            {
                if(String.Equals(sameArray, "no", StringComparison.OrdinalIgnoreCase))                       //If they wanted to input a different index, prompts the user 
                {
                    Console.WriteLine("\nOf the String List, which index would you like to display?");       //Asking for an index and converting it to int
                    displayInput = Convert.ToInt32(Console.ReadLine());
                }
                sameArray = "no";                                                                            //Changing Same Array to No so that if you decide to continue entering numbers it will loop through the previous if statement.

                arrayPrint(displayInput, 2);                                                                 //Sending the input and a value of 2 to determine the string type based on pre-set parameters
                if (Program.breakString != true) { x = loopArrays(); }                                       //Asking the user if they'd like to repeat the array and returning the value
                else { x = false; }
            }
            Console.WriteLine("\nThanks for checking out my program!");
            Console.ReadLine();                                                                              //Ending Statement for the Program
        }



        public static void arrayPrint(int indexNum, int arrayNum)                                            //Seperate Function that will check the input and repeat until a valid input has been entered
        {
            Program arrayRef = new Program();                                                                //In order to reference the arrays, an object of the program class has been created
            string arrayDisplay = "";                                                                        //Variable to hold whatever is in the index selected

            while (indexNum > 9 || indexNum < 0)                                                             //While Loop to check that the entered index is within the proper parameters
            {
                Console.WriteLine("\nThat is not a valid input. Please choose any number between 0 and 10.");
                indexNum = Convert.ToInt32(Console.ReadLine());                                              //If the input is not 0-10, repeats until a valid number is entered
            }
                                                                                                             //Nested Ternary Statement for assigning holding variable to either string array, int array, or string list
            arrayDisplay = arrayNum == 2 ? arrayRef.stringList[indexNum] :                                   //Assigning String List to Holding Var
                            arrayNum == 1 ? Convert.ToString(arrayRef.intArray[indexNum]) :                  //Assigning Int Array to Holding Var
                             arrayNum == 0 ? arrayRef.stringArray[indexNum] : "null";                        //Assigning String Array to Holding Var. Will return Null if none are returned.
            Console.WriteLine("The object in the index "+indexNum+" is "+arrayDisplay+".");                  //Prints the desired result that was assigned to the holding var
        }



        public static bool loopArrays()                                                                      //A function that asks the user if they'd like to continue through the loop and select another index
        {
            bool x = true;                                                                                   //Creating a variable to return
            string loopClause = "";                                                                          //Holding variable for input

            Console.WriteLine();                                                                             //Requesting input to continue through or exit to another array selection
            Console.WriteLine("Would you like to choose another index of the same array/list? Yes/No\nYou may type \"Break\" here to disable extra prompts.");  
            loopClause = Console.ReadLine();                                                    
            
            if (String.Equals(loopClause, "break", StringComparison.OrdinalIgnoreCase)) {                    //Statement reading if there is a break or if it's an expected outcome
                Program.breakString = true;                                                                  //If break is the input, it will change the global var to true and set X to false to exit the loop in Main
                x = false;
            } else { 
                x = String.Equals(loopClause, "yes", StringComparison.OrdinalIgnoreCase);                    //Checking input, will return true if "yes" is entered without case sensitivity
            }

            return x;                                                                                        //Returning true or false depending on the string comparison above
        }



        public static string keepIndex()                                                                     //Asking if they'd like to return the same index in the next Array
        {
            Console.WriteLine("\nWould you like to display the same index for the Integer Array? Yes or No."); 
            string sameInput = Console.ReadLine();
            return sameInput;
        }
    }
}
