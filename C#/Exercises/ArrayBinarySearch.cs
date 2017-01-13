using System;

namespace BinarySearchArray
{


    class Program
    {


        static void Main(string[] args)
        {
            int[] array = new int[10] { 33, 2, 937, 43, 6, 87, 99, 12, 724, 5 };
            Console.WriteLine("What number would you like to search the array for?");
            int search = int.Parse(Console.ReadLine());            
            int position = binSearch(array, search);
            if (position != -1)
            {
                Console.WriteLine("The target ({0}) was found at index {1}.",search,position);
            }else
            {
                Console.WriteLine("The target ({0}) was not found in the array.",search);
            }
            
           

        }

        public static int binSearch(int[] array, int search)
        {
            bubbleSort(array);
            int min = 0;
            int len = array.Length;
            int max = len-1;

            do
            {
                int mid = (min + max) / 2;
                if (search > array[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
                if (array[mid] == search)
                {
                    return mid;
                }
            } while (min <= max);
            return -1;            
        }


            public static int[] bubbleSort(int[] array)
        {
            int temp;
            int len = array.Length - 1;
            while (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
                len -= 1;
            }
            return array;
        }
    }
}