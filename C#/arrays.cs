            int[] randNumArray; // declaring an array
            int[] randArray = new int[5]; // declaring an array w/ 5 elements
            int[] randArray2 = { 1, 2, 3, 4, 5 }; // declaring an array and setting its value in the same line
	    
            Console.WriteLine("Array length is: " + randArray2.Length);
            Console.WriteLine("Item in index 0 is: " + randArray2[0]);
	    
            // This for loop prints out the value held in each index
            for(int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("Index {0} holds value {1}.", i, randArray2[i]);
            }
	    
            // This foreach loop does approximately the same thing as the for loop above.
            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }
	    
            Console.WriteLine("At what index does 1 show up? " + Array.IndexOf(randArray2, 1);
	    
            string[] names = { "Tom", "Paul", "Sally" };
            string nameStr = string.Join(",", names); // turns array into string separated by commas
            string[] nameArray = nameStr.Split(','); // splits string into array, breaking at commas. NOTE: break character must be in single quotes, and only 1 character
	    
            int[,] multArray = new int[5, 3]; // declaring a 5x3 array
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } }; // declaring a 3x2 array and setting values in same line
	    
            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }
	    
            // 2-dimensional for loop
            for(int x = 0; x < multArray2.GetLength(0); x++) // GetLength(0) looks only at the first dimension of multArray2, which has 3 elements
            {
                for(int y = 0; y < multArray2.GetLength(1); y++) // GetLength(1) looks only at the 2nd dimension
                {
                    Console.WriteLine("{0} | {1} : {2}",x,y,multArray2[x,y]); // multArray2[x,y] gives us only that particular element
                }
            }