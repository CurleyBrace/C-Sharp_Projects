using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello there " + yourName + ".");
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string inputNum = Console.ReadLine();
            int favNum = Convert.ToInt32(inputNum);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();

            bool isStudying = false;
            byte houseWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f;

            short temperaturesOnMars = -341;

            string myName = "tommy";

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            int currentAge = 30;
            string yearsOld = currentAge.ToString();


            Console.WriteLine(questionMark);
            Console.ReadLine();


        }
    }
}
