using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace GradeBook
{
    public class Score
    {
        // Fields and Properties
        public List<double> Scores { get; set; }
        //Constructor
        public Score()
        {
            this.Scores = new List<double>();
        }
        //Input and Validate Method/Behaviour
        public void AddScore()
        {
            do
            {
                Console.Write("Type a score between 0 - 100 , [111 to terminate] :");
                string inputScore = Console.ReadLine();
                double Score;
                bool condition = double.TryParse(inputScore, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out Score);

                while (!condition || Score < 0 || Score > 100)
                {
                    if (Score == 111)
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PLEASE PROVIDE A VALID NUMBER BETWEEN 0 - 100...");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Type a score between 0 - 100 , [111 to terminate] :");
                    inputScore = Console.ReadLine();
                    condition = double.TryParse(inputScore, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out Score);
                }
                if (Score == 111)
                {
                    break;
                }
                else
                {
                    this.Scores.Add(Score);
                }
            } while (!Scores.Contains(111));

        }
        //Compute Statistics Method/Behaviour
        public Statistics GetStatistics()
        {
            if (Scores.Count != 0)
            {
                Statistics statistics = new Statistics();
                statistics.Highest = Scores.Max();
                statistics.Lowest = Scores.Min();
                statistics.Average = Scores.Average();

                return statistics;
            }
            return new Statistics { Average = 0, Highest = 0, Lowest = 0 };

        }
        //Output Statistics Method/Behaviour
        public void DisplayStatistics()
        {
            Console.WriteLine($"{$"Highest Score :{Math.Round(GetStatistics().Highest, 1)}",70}");
            Console.WriteLine($"{$"Lowest Score :{Math.Round(GetStatistics().Lowest, 1)}",70}");
            Console.WriteLine($"{$"Average Score :{Math.Round(GetStatistics().Average, 1)}",70}");
        }
    }
}
