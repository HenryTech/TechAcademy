using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication3
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] custs = new string[] { "Tom", "Paul", "Greg" };

            // By using StreamWriter, we can make lines in custs.txt for each name in the custs list.
            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }

            // By using StringReader, we can then go back to custs.txt and look at each line individually. In this case, we write each line out in the console.
            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
        }
    }
}
