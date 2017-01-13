using System;

namespace ForLoopDescAsterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 7; i > 0; i--)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
