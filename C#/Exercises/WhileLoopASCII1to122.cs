using System;

namespace WhileLoopASCII1to122
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 122)
            {
                Console.Write(num+":"+(char)num+"\t");
                if (num % 10 == 0)
                {
                    Console.Write("\n");
                }
                num++;
            }
            
        }
    }
}
