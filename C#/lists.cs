            List<int> numList = new List<int>(); // declaring a new integer list

            numList.Add(5); // adding elements to the list
            numList.Add(15);
            numList.Add(25);

            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray); // adds the contents of the array to the list

            List<int> numList2 = new List<int>(randArray); // new list with just the array in it
            List<int> numList3 = new List<int>(new int[] { 5, 6, 7 }); // also a new list with just an array in it
            numList.Insert(1, 10); // insert 10 at the 1 index
            numList.Remove(5); // remove the value 5 from the list
            numList.RemoveAt(2); // remove value at index 2 from the list
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.WriteLine("The number 4 is in index position " + numList3.IndexOf(4)); // will return the index position of value 4, or will return -1 if value 4 is not present
            Console.WriteLine("Is 5 in the list? " + numList.Contains(5)); // returns boolean

            List<string> strList = new List<string>(new string[] { "Tom", "Paul" }); // starts a new string list and populates it with a string array
            Console.WriteLine("Is Tom in the list? " + strList.Contains("Tom"); // checks for presence of "Tom". Will return -1 if "Tom" isn't in the list
            Console.WriteLine("Is Tom in the list? " + strList.Contains("tom",StringComparer.OrdinalIgnoreCase); // will ignore case and find "tom" even if the T isn't capitalized
            strList.Sort(); // will sort list in alphabetic order, or numerically depending on contents of list