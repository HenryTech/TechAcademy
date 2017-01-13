using System;

namespace WhileLoopMultipleChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the command keyword to exit a loop in C#?");
            Console.WriteLine();
            Console.WriteLine("a. int");
            Console.WriteLine("b. continue");
            Console.WriteLine("c. break");
            Console.WriteLine("d. exit");
            Console.WriteLine();
            string loop = "y";
            while (loop == "y")
            {
                Console.WriteLine("Enter your choice:");
                string choice = (Console.ReadLine()).ToLower();
                if (choice == "c")
                {
                    Console.WriteLine("Excellent! You are correct!");
                    loop = "n";
                }else if ((choice == "a") || (choice == "b") || (choice == "d"))
                {
                    Console.WriteLine("Incorrect choice. Would you like to try again?");
                    loop = (Console.ReadLine()).ToLower();
                }else
                {
                    Console.WriteLine("Invalid choice. Would you like to try again?");
                    loop = (Console.ReadLine()).ToLower();
                }
                
            }
            
        }
    }
}
