using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{    
    class Fraction
    {
        public int numerator;
        public int denominator;
    }
    struct Sfrac
    {
        public int numerator;
        public int denominator;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // When I create a new instance of the Fraction class, I'm creating an object. Objects are reference types. They aren't the thing itself, but rather a pointer to the thing.
            Fraction fract1 = new Fraction
            {
                numerator = 1,
                denominator = 2
            };
            // So when I set another object equal to the first, both objects are referencing the same location in memory. 
            // When fract2.numerator is changed, fract1.numerator follows right along, since all they are is pointers or references to a thing.
            Fraction fract2 = fract1;
            fract2.numerator = 10;
            Console.WriteLine(fract1.numerator);

            // On the other hand, when I instantiate a structure, I'm creating a value type. Rather than being a pointer, it is the thing itself.
            Sfrac sfract1 = new Sfrac
            {
                numerator = 1,
                denominator = 2,
            };
            // So when I set another variable equal to the value type sfract1, I'm not just making another pointer to a location in memory (like the object above), I'm creating an entirely new thing.
            // Since this is an entirely new thing, when I change sfract2's numerator, sfract1's numerator remains unchanged.
            Sfrac sfract2 = sfract1;
            sfract2.numerator = 10;
            Console.WriteLine(sfract1.numerator);
        }
    }
}
