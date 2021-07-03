using System;

namespace constructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string varOne = "Hello ";         //Creating a Constant var
            var varTwo = "World.";                  //Declaring a variable with just Var

            Console.WriteLine("First Constructor");     //Outputting, and calling the constructor method from the other class
            constructors studentOne = new constructors("Tim", "John");

            Console.ReadLine();
        }
    }
}
