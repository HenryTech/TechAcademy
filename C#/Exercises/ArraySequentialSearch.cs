using System;

namespace SequentialSearchArray
{


    class Program
    {


        static void Main(string[] args)
        {
            int[] array = new int[10] { 33, 2, 937, 43, 6, 87, 99, 12, 724, 5 };
            Console.WriteLine("What number would you like to search the array for?");
            int search = int.Parse(Console.ReadLine());
            int len = array.Length;
            int position = seqSearch(array, search, len);
            if (position != -1)
            {
                Console.WriteLine("The target ({0}) was found at index {1}.",search,position);
            }else
            {
                Console.WriteLine("The target ({0}) was not found in the array.",search);
            }
            
           

        }

        public static int seqSearch(int[] array, int search, int len)
        {
            int found = 0;
            int position = -1;                       
            for(int i=0; i < len && found != 1; i++)
            {
                if (search == array[i])
                {
                    position = i;
                    found = 1;
                }
            }
            return position;




        }
    }

}