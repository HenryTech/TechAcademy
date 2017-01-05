            // Relational operators: > < >= <= == !=
            // Logical operators: && || ^(exclusive or) !
            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine(("Go to kindergarten.");
            } else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school.");
            }else
            {
                Console.WriteLine("Go to high school.");
            }
            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You should not be working.");
            }
            bool canDrive = age >= 16 ? true : false; // ternary operator: ?=then, :=else
	    switch (age)
            {
                case (0): // in case age = 0
                    Console.WriteLine("Infant");
                    break; // break is neccessary or conditional will keep running
                case (1): // in case age = 1 OR
                case (2): // in case age = 2
                    Console.WriteLine("Toddler");
                    goto Cute; // goto is possible, but causes messes and should be avoided--break is preferred
                default:
                    Console.WriteLine("Child");
                    break;
            }
            Cute:
            Console.WriteLine("Toddlers are cute!");