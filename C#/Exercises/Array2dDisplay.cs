using System;

namespace Array2dDisplay
{


    class Program
    {


        static void Main(string[] args)
        {
            // 2d Array can be set up manually or, as seen further below, programatically.
            // int[,] array2d = new int[5,5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };


            int[,] array2d = new int[5, 5];

            // This is one way to generate the array
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i == 0) // fill the first row
                    {
                        array2d[i, j] = j + 1;
                    }else if (i > 0 && j == 0)
                    {
                        array2d[i, j] = array2d[i - 1, 4] + 1; // fetch value of last cell in previous row, for first cell in each row after first row
                    }else
                    {
                        array2d[i, j] = array2d[i, j - 1] + 1; // fill subsequent cells
                    }
                }
            }

            // This is a simpler way to generate the array
            int dimension = 5;
            for(int i = 0; i < dimension; i++)
            {
                for(int j = 0; j < dimension; j++)
                {
                    array2d[i, j] = i * dimension + j + 1;
                }
            }

            // Print 2d array.
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array2d[i,j]+"\t");
                }
                Console.WriteLine();
            }
            
            
           

        }

        
    }
}