using System;

namespace GradeBook
{
    class Program
    {
        static void Header()
        {
            const int PADLEFT = 65;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Score Board",PADLEFT}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
        static void Footer()
        {
            const int PADLEFT = 65;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Statistics",PADLEFT}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            Header();

            //Instantiating Score Class Object
            Score score = new Score();

            //Invoke Input and Validation Method
            score.AddScore();

            Footer();

            //Invoke Compute Statistics Method
            score.DisplayStatistics();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadKey();
        }
    }
}
