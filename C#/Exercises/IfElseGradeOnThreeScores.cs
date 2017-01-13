using System;

namespace IfElseGradeOnThreeScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student's quiz score");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student's midterm score");
            x += int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student's final score");
            x += int.Parse(Console.ReadLine());
            if ((x / 3) >= 90)
            {
                Console.WriteLine("A grade.");
            }
            else if ((x / 3) >= 70)
            {
                Console.WriteLine("B grade.");
            }
            else if ((x / 3) >= 50)
            {
                Console.WriteLine("C grade.");
            }
            else
            {
                Console.WriteLine("FAIL! F grade.");
            }           
        }
    }
}
