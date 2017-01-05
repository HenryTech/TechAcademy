using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    // First, let me declare a delegate that takes returns a bool and takes an integer as an argument.
    delegate bool MyDelegate(int n);
    delegate void ComboDel(IEnumerable<int> listName);

    class Program
    {
        // Now I'm going to set up a few methods that return bools and take integers as arguments.
        static bool ltTen(int n)
        {
            return n < 10;
        }
        static bool ltFifty(int n)
        {
            return n < 50;
        }
        static bool gtFiveHun(int n)
        {
            return n > 500;
        }

        // Now I can set up a method that will use MyDelegate to determine which conditional I want to use to filter an int list.
        static IEnumerable<int> RunListThroughGauntlet(IEnumerable<int> numbers, MyDelegate gauntlet)
        {
            foreach(int number in numbers)
            {
                if (gauntlet(number))
                    yield return number;
            }
        }

        static void lt10Method(IEnumerable<int> listName)
        {
            IEnumerable<int> ltTenResult = RunListThroughGauntlet(listName, ltTen);
            Console.WriteLine("All values in hugeList less than 10:");
            foreach (int n in ltTenResult)
            {
                Console.WriteLine(n);
            }
        }

        static void lt50Method(IEnumerable<int> listName)
        {
            IEnumerable<int> ltFiftyResult = RunListThroughGauntlet(listName, ltFifty);
            Console.WriteLine("-----------------------------------\nAll values in hugeList less than 50:");
            foreach (int n in ltFiftyResult)
            {
                Console.WriteLine(n);
            }
        }

        static void gt500Method(IEnumerable<int> listName)
        {
            IEnumerable<int> gtFiveHunResult = RunListThroughGauntlet(listName, gtFiveHun);
            Console.WriteLine("-----------------------------------\nAll values in hugeList greater than 500:");
            foreach (int n in gtFiveHunResult)
            {
                Console.WriteLine(n);
            }
        }
        
        static void Main(string[] args)
        {
            // I need to set up my big unwieldy list, now.
            int[] hugeList = new[] { 3, 7, 4, 8, 10, 55, 3, 88, 91238, 58, 9032, 272, 28, 53, 338, 39, 1823, 47854, 37, 573, 22, 59, 847, 2749, 294, 3849, 19398, 749, 20 };
            // I can now choose how I want to filter that huge list by specifying which method I want to plug in to the gauntlet method.

            ComboDel allOfIt = lt10Method;
            allOfIt += lt50Method;
            allOfIt += gt500Method;

            allOfIt(hugeList);
            
           
        }
    }
}
