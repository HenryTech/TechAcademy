using System;

namespace RandomNumberGuesserWithContinue
{


    class Program
    {


        static void Main(string[] args)
        {

            ranguess();

            Console.ReadLine();

        }

        public static void ranguess()
        {
            int guess, secret;
            int con = 1;
            Random rand = new Random(); //create random object
            while (con == 1)
            {
                Console.WriteLine("Try to guess what number I just rolled!");
                Console.Write("Enter your guess number:");
                guess = int.Parse(Console.ReadLine());
                secret = rand.Next(1, 7); //generate random number from 1 t0 6                
                if (guess == secret)
                {
                    Console.WriteLine("Holy smokes! You won!");

                }
                else
                {
                    Console.WriteLine("You lost.");
                    Console.WriteLine("My number is {0}.", secret);

                }

                Console.Write("Press 1 to continue:");
                con = int.Parse(Console.ReadLine());


            }

        }
    }

}