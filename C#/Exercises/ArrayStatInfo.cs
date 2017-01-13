using System;

namespace ArrayStatInfo
{
    class Program
    {

        static void Main(string[] args)
        {
            buildArray();
        }

        public static void buildArray()
        {
            int member = 0;
            int loop = 0;
            int size = 0;
            while (loop == 0)
            {
                Console.WriteLine("How many members in the array?");
                size = int.Parse(Console.ReadLine());
                if (size < 3)
                {
                    Console.WriteLine("You need to make a larger array than that!");
                }else
                {
                    loop = 1;
                }
            }
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Input value #{0}:",i+1);
                bool success = false;
                while (success == false)
                {
                    success = int.TryParse(Console.ReadLine(), out member);
                    if (success == false)
                    {
                        Console.WriteLine("Your value must be an integer!");
                        Console.WriteLine("Try again to input an interger value:");
                    }
                }                
                array[i] = member;
            }
            Console.WriteLine();
            bubbleSort(array);
            statInfo(array);
        }

        public static void statInfo(int[] array)
        {
            Console.WriteLine("Statistical information about array:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Arithmetic mean: {0}", arrayMean(array));
            Console.WriteLine("Median: {0}", arrayMedian(array));
            Console.WriteLine("Mode: " + arrayMode(array));
            Console.WriteLine("Standard deviation: {0}", arrayStdDev(array));
        }

        // Find the mean by adding all the values together and dividing by number of values.
        public static double arrayMean(int[] array)
        {
            double mean;
            double sum = 0;
            double len = array.Length;
            foreach (double v in array)
            {
                sum += v;
            }
            mean = sum / len;
            return mean;
        }

        // Find the median by sorting first, then taking the middle value (or average of two middle values, in the case of an even number of values).
        public static double arrayMedian(int[] array)
        {
            double median;
            int len = array.Length;            
            if (len % 2 == 0)
            {
                double value1 = array[len / 2];
                double value2 = array[(len / 2) - 1];
                median = (value1 + value2) / 2;
            }else
            {
                median = array[len / 2];
            }
            return median;
        }

        // Mode is tricky. I used code from the example because I had already spent 6 hours on it.
        public static string arrayMode(int[] array)
        {
            int len = array.Length;
            int[,] mode = new int[len, 2];
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < len; j++)
                {
                    mode[j, i] = 0;
                    mode[0, 0] = 1;
                }
            }

            for(int i = 0; i < len; i++)
            {
                for(int j = 0; j < len-1; j++)
                {
                    if (array[i] == array[j + 1])
                    {
                        ++mode[i, 0];
                        mode[i, 1] = array[i];
                    }
                }
            }

            int max;
            int k = 0;
            max = mode[0, 0];
            for (int j = 0; j < len; j++)
            {
                if (max < mode[j, 0])
                {
                    max = mode[j, 0];
                    k = j;
                }
            }
            if (mode[k, 1] != 0)
            {
                return mode[k, 1].ToString();
            }else
            {
                return "no mode";
            }       
        }

        // Std dev requires several steps, but is much simpler than finding mode
        public static double arrayStdDev(int[] array)
        {            
            double stddev=new double();
            double mean=new double();
            double variance=new double();
            double totalValue=new double();
            double len = array.Length;

            // First, calculate the mean
            foreach (double v in array)
            {
                totalValue += v;
            }
            mean = totalValue / len;

            // Next, caluculate the variance of each value vs the mean, adding them together as we go, then dividing by len-1.
            foreach(double value in array)
            {                
                variance += (value-mean) * (value-mean);                
            }
            variance = variance / (len - 1);            

            // Finally, take the square root of the variance
            stddev = Math.Sqrt(variance);
            return stddev;
        }

        public static int[] bubbleSort(int[] sort)
        {
            int temp;
            int len = sort.Length - 1;
            while (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    if (sort[i] > sort[i + 1])
                    {
                        temp = sort[i + 1];
                        sort[i + 1] = sort[i];
                        sort[i] = temp;
                    }
                }
                len -= 1;
            }
            return sort;
        }

    }
}