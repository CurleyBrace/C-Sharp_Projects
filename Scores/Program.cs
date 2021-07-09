using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = DateTime.Today.ToShortDateString();
            Console.WriteLine("Please enter in your first name.");            
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\Tommy\Documents\HTML and CSS Projects\Tech Academy Work\C-Sharp_Projects\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }
            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage Score " + avgScore);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
