using System;

namespace IfElseGreatestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical value");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another numerical value");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third and final numerical value");
            int z = int.Parse(Console.ReadLine());
            if ((x > y) && (x > z))
            {
                Console.WriteLine("The largest number is "+x);
            }
            if ((y > x) && (y > z))
            {
                Console.WriteLine("The largest number is "+y);
            }
            if ((z > x) && (z > y))
            {
                Console.WriteLine("The largest number is "+z);
            }
                               
           
        }
    }
}
