            double num1 = 10.6;
            double num2 = 15;
            Console.WriteLine("Math.Abs(num1) = " + Math.Abs(num1));
            Console.WriteLine("Math.Ceiling(num1) = " + Math.Ceiling(num1));
            Console.WriteLine("Math.Floor(num1) = " + Math.Floor(num1));
            Console.WriteLine("Math.Max(num1, num2) = " + Math.Max(num1, num2));
            Console.WriteLine("Math.Min(num1, num2) = " + Math.Min(num1, num2));
            Console.WriteLine("Math.Pow(num1, 2) = " + Math.Pow(num1, 2));
            Console.WriteLine("Math.Round(num1) = " + Math.Round(num1));
            Console.WriteLine("Math.Sqrt(num1) = " + Math.Sqrt(num1));
            Random rand = new Random(); // rand is now a random number generator
            Console.WriteLine("Random number between 1 and 10: " + (rand.Next(1, 11)));