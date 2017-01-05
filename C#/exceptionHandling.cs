            // Here's a snippet that we know might throw a specific error
            try
            {
                Console.WriteLine("Divide 10 by: ");
                int num = int.Parse(Console.ReadLine()); // parse turns string into integer
                Console.WriteLine("10 / {0} = {1}",num,(10/num));
            }
            catch (DivideByZeroException ex) // if this particular error is thrown by the try block, the catch block will execute
            {
                Console.WriteLine("Can't divide by zero.");
                Console.WriteLine(ex.GetType().Name); // gets name of exception
                cw(ex.Message); // gets message associated with exception
            }