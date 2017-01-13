using System;

namespace ArrayStemLeaf
{
    class Program
    {

        static void Main(string[] args)
        {
            buildDataset();
        }

        public static void buildDataset()
        {
            int member = 0;
            int loop = 0;
            int size = 0;
            while (loop == 0)
            {
                Console.WriteLine("How many members in the dataset?");
                size = int.Parse(Console.ReadLine());
                if (size < 3)
                {
                    Console.WriteLine("You need to make a larger dataset than that!");
                }else
                {
                    loop = 1;
                }
            }
            int[] dataset = new int[size];
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
                dataset[i] = member;
            }
            Console.WriteLine();
            bubbleSort(dataset);
            datasetDisplay(dataset);
        }

        public static void datasetDisplay(int[] dataset)
        {
            Console.WriteLine("Sorted dataset:");
            for(int i = 0; i < dataset.Length; i++)
            {
                Console.Write(dataset[i]+"\t");
                if ((i + 1) % 5 == 0)
                {
                    Console.Write("\n");
                }                
            }
            Console.WriteLine();
            Console.WriteLine();
            stemAndLeaf(dataset);
        }

        public static void stemAndLeaf(int[] dataset)
        {
            // format variables, including stemleaf 2d array (len x 2)
            int i, j;
            int len = dataset.Length;  
            int[,] stemleaf = new int[len, 2];  

            // set up 2d array to hold 10s in column 0, 1s in column 1
            for(i=0; i < len; i++)
            {
                stemleaf[i, 0] = dataset[i] / 10;
                stemleaf[i, 1] = dataset[i] % 10;
            }

            // format mode array and zero it out
            int[,] mode = new int[len, 2];
            for (i = 0; i < len; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    mode[i, j] = 0;
                }
            }
            mode[0, 0] = 1;


            int count = 1;
            for (i = count - 1; i < len; i++)
            {
                for (j = count - 1; j < len - 1; j++)
                {
                    if (stemleaf[i, 0] == stemleaf[j + 1, 0])
                    {
                        count++;
                        mode[i, 0]++;
                        mode[i, 1] = stemleaf[i, 0];
                    }else if (i == 0)
                    {
                        mode[i, 1] = stemleaf[i, 0];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Stem and leaf display:");
            Console.WriteLine("Frequency\tStem\tLeaf");
            Console.WriteLine("=================================");
            int c = 0, leaf = 0;
            for (i = 0; i < len; i++)
            {
                if (mode[i, 1] != 0)
                {
                    leaf += mode[i, 0];
                    Console.Write(mode[i, 0] + "\t\t");
                    Console.Write(mode[i, 1] + "\t");
                    for (j = c; j < leaf; j++)
                    {
                        Console.Write(stemleaf[j,1]);
                    }
                    c = leaf;
                    Console.WriteLine();
                }
            }                      
        }        

        public static int[] bubbleSort(int[] dataset)
        {
            int temp;
            int len = dataset.Length - 1;
            while (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    if (dataset[i] > dataset[i + 1])
                    {
                        temp = dataset[i + 1];
                        dataset[i + 1] = dataset[i];
                        dataset[i] = temp;
                    }
                }
                len -= 1;
            }
            return dataset;
        }

    }
}