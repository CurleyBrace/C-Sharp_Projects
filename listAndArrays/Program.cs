using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace listAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y = true;

            while (y == true)
            {
                Console.WriteLine("There are 6 parts to this console assignment,\nPlease choose where you would like the program to being:");    //Giving the user options per assignment
                Console.WriteLine("1. Array Appending");
                Console.WriteLine("2. Infinite Loop with Fix");
                Console.WriteLine("3. Iterating through with < and <=");
                Console.WriteLine("4. String List with Unique Values");
                Console.WriteLine("5. String List with Matching Values");
                Console.WriteLine("6. String List with Matching Values and Parsing through to Check");
                int contextInput = Convert.ToInt32(Console.ReadLine());                                                         //Taking input and using it to determine the switch statement below

                switch (contextInput)
                {
                    case 1:
                        Console.WriteLine("\n----------Assignment 1----------");
                        string[] stringArray = new string[5] { "Test 1: ", "Test 2: ", "Test 3: ", "Test 4: ", "Test 5: " };    //Array of Strings
                        Console.WriteLine("\nPlease input some text.");
                        string textInput = Console.ReadLine();                                                                  //Taking input to add to each item in the string

                        for (int i = 0; i < stringArray.Length; i++)                                                            //Traveling through the array and adding the input to each String
                        {
                            stringArray[i] += textInput;
                        }
                        for (int i = 0; i < stringArray.Length; i++)                                                            //Second Part of the Assignment, printing each line with the newly added values
                        {
                            Console.WriteLine(stringArray[i] + "\n");
                        }
                        Thread.Sleep(1000);                                                                                     //Quality of Life Addition. Waits 1s before moving to the next assignment
                        goto case 2;                                                                                            //Moves to the next case

                    case 2:
                        Console.WriteLine("\n----------Assignment 2----------");                                                
                        for (int i = 0; i < 1; i++)                                                                             //Created an infinite Loop and then fixed it.
                        {
                            Console.WriteLine("Infinite Loop\nFixed");
                        }
                        Thread.Sleep(1000);                                                                                      
                        goto case 3;                                                                                            //Moving to the next case

                    case 3:
                        Console.WriteLine("\n----------Assignment 3----------");
                        for (int i = 0; i < 1; i++)                                                                             //Operating through a for Loop using a < operator
                        {
                            Console.WriteLine("Iterating through with < operator, index: " + i + ".");
                        }
                        for (int i = 1; i <= 2; i++)                                                                            //Operating through a for Loop using a <= operator
                        {
                            Console.WriteLine("Iterating through with <= operator, index: " + i + ".");
                        }
                        Thread.Sleep(1000);
                        goto case 4;                                                                                            //Moving to the next case

                    case 4:
                        Console.WriteLine("\n----------Assignment 4----------");
                        List<string> uniqueNames = new List<string>() { "Tommy", "Michael", "Joe", "Alex", "Sarah" };           //Pre-assigned List of STrings
                        int cntr = 1;                                                                                           //Counter for Printing the List

                        foreach (string printList in uniqueNames)                                                               //Printing the List so the user knows their options
                        {
                            Console.WriteLine(cntr + ". " + printList);
                            cntr++;
                        }
                        Console.WriteLine("--------------------------------");
                        bool x = true;                                                                                          //While Loop Boolean
                        bool contains = false;                                                                                  //Boolean that controls whether or not an item is in the List
                        string inputText;                                                                                       //Input String Var      

                        while (x == true)                                                                                       //While Loop Start
                        {
                            Console.WriteLine("\nPlease input text to search for in the list.");                                //Taking an input to search
                            inputText = Console.ReadLine();

                            foreach (string name in uniqueNames)                                                                //Parsing through List to find if Input Text is in the list and the index of it.
                            {
                                if (name == inputText)
                                {
                                    Console.WriteLine(inputText + " was found at index " + uniqueNames.IndexOf(inputText) + ".");
                                    contains = true;
                                    x = false;
                                    break;                                                                                      //Breaking the Loop if it was found
                                }
                            }

                            if (contains == false)
                            {
                                Console.WriteLine("There are no matches to " + inputText + " in the list.");                    //If not found, notifies the user
                            }
                        }
                        Thread.Sleep(1000);
                        goto case 5;                                                                                            //Moves to the next case

                    case 5:
                        Console.WriteLine("\n----------Assignment 5----------");
                        List<string> matchingNames = new List<string> { "Jeff", "Tim", "Michael", "Richard", "Tim" };
                        cntr = 1;

                        foreach (string printList in matchingNames)                                                             //Printing the List so the user knows their options
                        {
                            Console.WriteLine(cntr +". "+ printList);
                            cntr++;
                        }
                        Console.WriteLine("--------------------------------");


                        string matchingInd = "The matching index/indices are: ";                                                //Output String
                        bool j = true;                                                                                          //Boolean to control if the input was successful
                        int index = 0;                                                                                          //Counter Variable

                        while (j == true)                                                                                       //While Loop Start
                        {
                            Console.WriteLine("Please enter text to search through the Lists.");                                //Taking an input to search for
                            inputText = Console.ReadLine();

                            foreach (string name in matchingNames)                                                              //Parsing through list to find input
                            {
                                if (name == inputText)
                                {
                                    if (j == false) { matchingInd += " and "; }                                                 //Adds readability if there are multiple indicies to list
                                    matchingInd += matchingNames.IndexOf(name, index);                                          //Adds the index to the String
                                    index = matchingNames.IndexOf(name) + 1;                                                    //Updates the counter variable
                                    j = false;                                                                                  //Sets while loop to false
                                }
                            }
                            var output = j == true ? "The text you entered was not part of the list.\n" : matchingInd;          //If while loop was never set to false, asks for another input, or sets output String
                            Console.WriteLine(output);                                                                          //Displaying output
                        }
                        Thread.Sleep(1000); 
                        goto case 6;                                                                                            //Moves to the final case

                    case 6:
                        Console.WriteLine("\n----------Assignment 6----------");                                                //Pre-made string with multiple similar values
                        List<string> identicalNamesTwo = new List<string> { "Jeff", "Michael", "Joe", "Jeff", "Thomas", "Sarah", "Michael" };
                        bool nameAppears = false;                                                                               //Variable to keep track of a name appearing more than once
                        int counter = -1;                                                                                       //Counter starts at -1 to account for the loop not including the variable it's comparing

                        foreach (string trackName in identicalNamesTwo)                                                         //Parsing through each value in the List
                        {
                            for (int k = counter; k >= 0 && k < identicalNamesTwo.Count; k--)                                   //Compares Every value in the list that was before the current one 
                            {
                                if (trackName == identicalNamesTwo[k])                                                          //If there is a value that exists before the current value, this branch is triggered
                                {
                                    {
                                        nameAppears = true;                                                                     //Sets boolean to true for name appearing
                                        break;                                                                                  //Exits For Loop. We do not need to know how many times it appears, just if it does or not
                                    }
                                }
                            }
                            Console.WriteLine(trackName + " has appeared previously: " + nameAppears);                          //Output for each item in the list
                            nameAppears = false;                                                                                //Resets Boolean for Name Appears
                            counter++;                                                                                          //Increases the Counter for the For Loop
                        }
                        break;

                    default:
                        Console.WriteLine("That was not a valid entry. Please try again.");                                     //Incase of an error with the Switch
                        break;
                }

                Console.WriteLine("\nWould you like to go through again? Yes or No");                                           //Allows the user to go again, takes an input
                string loopInput = Console.ReadLine();

                y = String.Equals(loopInput, "yes", StringComparison.OrdinalIgnoreCase) ? true : false;                         //While loop boolean, compares to "yes", if true will repeat
            }

            Console.WriteLine("\nThank you for using my program!");
            Console.ReadLine();
        }
    }
}
