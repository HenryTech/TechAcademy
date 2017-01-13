using System;

namespace ArrayMatrixGenerateDisplay
{


    class Program
    {


        static void Main(string[] args)
        {
            int[,] array2d = new int[5, 5];
            
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        array2d[i, j] = 0;
                    }else if (j > i)
                    {
                        array2d[i, j] = 1;
                    }else
                    {
                        array2d[i, j] = -1;
                    }
                }
            }
            print2dArray(array2d);
        }

        public static void print2dArray(int[,] array2d)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array2d[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}