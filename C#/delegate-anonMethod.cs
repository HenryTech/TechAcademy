using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A delegate is defined outside of the class and is used inside an anonymous method.
delegate double GetSum(double num1, double num2);

namespace ConsoleApplication3
{

    class Program
    {
        static void Main(string[] args)
        {
            // Now I set up an anonymous method, whose data type is set by what it returns.
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = " + sum(5,10));
            
        }
    }
}
