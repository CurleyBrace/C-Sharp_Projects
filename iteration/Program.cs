using System;
using System.Collections.Generic;

namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 82, 34, 91, 80, 20 };
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] >= 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //string[] names = { "Tommy", "Eric", "Danny", "Alex" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    if(names[j] == "Tommy") { Console.WriteLine(names[j]); }              
            //}

            //List<int> testScores = new List<int>();
            //testScores.Add(93);
            //testScores.Add(91);
            //testScores.Add(13);
            //testScores.Add(48);
            //testScores.Add(75);
            //testScores.Add(89);

            //foreach (int score in testScores)
            //{
            //    if (score >= 85)
            //    {
            //        Console.WriteLine("Passing test score: "+score);
            //    }
            //}

            //List<string> names = new List<string> { "Bob", "Jeff", "Tommy", "Michael", "Jay" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            List<int> testScores = new List<int>() { 98, 93, 81, 23, 75, 43, 68, 100 };
            List<int> passingScores = new List<int>();

            foreach ( int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
        }
    }
}
