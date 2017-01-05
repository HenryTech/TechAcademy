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
            //This is a lambda expression, which acts as an anonymous function. The defining feature of a lambda function is the =>, with variable(s) listed on the left side and an expression listed on the right.
            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5 + 3 = " + getSum.Invoke(5,3));

            // I'm creating a new list here, to use below.
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };

            // Now I use a lambda expression that iterates through the above list to pull out only the odd numbers, store them in a list (ToList()) and store them in oddNums.
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

            foreach (int num in oddNums)
            {
                Console.WriteLine(num + ",");
            }
            
        }
    }
}
