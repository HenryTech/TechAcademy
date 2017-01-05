            string randString = "Some random words";
            string sampString = "Some more random words";

            Console.WriteLine("Is randString empty? " + String.IsNullOrEmpty(randString));
            Console.WriteLine("Is randString empty? " + String.IsNullOrWhiteSpace(randString));
            Console.WriteLine("String length: " + randString.Length);
            Console.WriteLine("Index of 'random': " + randString.IndexOf("random")); // will print out index where word "random" starts. If no substring "random" found, will return -1.
            Console.WriteLine("What's the 2nd word? " + randString.Substring(5,10));
            Console.WriteLine("Are the strings equal? " + randString.Equals(sampString));
            Console.WriteLine("Does the string start with 'Some'? " + randString.StartsWith("Some");
            Console.WriteLine("Does the string end with 'words'? " + sampString.EndsWith("words");
            sampString = sampString.Trim(); // removes start and end whitespace
            sampString = sampString.TrimEnd(); // removes end whitespace
            sampString = sampString.TrimStart(); // removes start whitespace
            sampString = sampString.Replace("words", "characters"); // replaces first argument with 2nd argument
            sampString = sampString.Remove(0, 2); // removes characters starting with index 0 and stopping at index 2, non-inclusive
            string[] names = new string[3]; // declares names as new string array w/ length 3
            string[] names = new string[3] { "Matt", "Jason", "Josh" }; // declare it and set it on the same line
            Console.WriteLine("List of names: " + String.Join(",", names)); // join an array using , to separate elements
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, 30.56, 100000000); // formats numbers in different ways. 0 is currency format, 1 is explicit 2 places ea. side of decimal, 2 is any number of places to the left, 2 places to the right of decimal, and 3 is standard large number format, with commas (1,000,000)