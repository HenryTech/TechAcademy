using System;

namespace Array10BubbleSort
{
    class Program
    {
	    
	    
        static void Main(string[] args)
        {
            int[] sort = new int[10] { 33, 2, 937, 43, 6, 87, 99, 12, 724, 5 };
            Console.WriteLine("Initial array:");
            foreach(int i in sort)
            {
                Console.Write(i+",");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            foreach(int i in (bubbleSort(sort)))
            {
                Console.Write(i+",");
            }
            Console.WriteLine();
	}
	

        public static int[] bubbleSort(int[] sort)
        {
            int temp;
            int len = sort.Length - 1;            
            while(len>0)
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