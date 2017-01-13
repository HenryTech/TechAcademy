using System;

namespace ForLoopDescAsteriskAscNumeral
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 7; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for(int k = 7 - i; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
