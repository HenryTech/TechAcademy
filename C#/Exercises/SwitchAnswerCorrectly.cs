using System;

namespace SwitchAnswerCorrectly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the correct way to store an integer value in C#?");
            Console.WriteLine();
            Console.WriteLine("a. int 1x=10");
            Console.WriteLine("b. int x=10");
            Console.WriteLine("c. float x=10.0f");
            Console.WriteLine("d. string x=\"10\"");
            Console.WriteLine();
            Console.WriteLine("Chose the letter of the correct answer:");
            char c = (char)Console.Read();

            switch (c)
            {
                case 'b':
                    Console.WriteLine("You chose correctly!");
                    break;
                case 'a':
                    Console.WriteLine("You chose incorrectly!");
                    break;
                case 'c':
                    Console.WriteLine("You chose incorrectly!");
                    break;
                case 'd':
                    Console.WriteLine("You chose incorrectly!");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }     
            
        }
    }
}
