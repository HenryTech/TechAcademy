	    int i = 0;
            // This is a while loop.
            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue; // returns to start of loop
                }
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            // This is a do/while loop.
            string guess;
            do
            {
                Console.WriteLine("Guess a number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15")); // this is how to check for string equality, or inequality in this case
            // this while loop will keep going until guess.Equals("15"), lopping back to the do
            // This is a for loop
            for(int i = 0; i < 10; i++)
            {
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
            }

            // This is a foreach loop
            string randStr = "Some random characters.";
            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }