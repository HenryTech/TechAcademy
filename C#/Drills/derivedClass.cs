using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string covering { get; set; }
        public string sound { get; set; }
        public string name { get; set; }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.covering = "Bare skin";
            this.name = "No name";
            this.sound = "No sound";
        }

        public Animal(double height, double weight, string covering, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.covering = covering;
            this.name = name;
            this.sound = sound;
        }

        public override string ToString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} pounds, is covered in {3} and makes a {4} sound.", name, height, weight, covering, sound);
        }

        // METHOD OVERLOADING: Since I'm defning this method twice, with different types of input variables and a different type of return, the program will use whichever one is appropriate.
        public int compute(int num1, int num2)
        {
            return num1 + num2;
        }

        public double compute(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    // Dog will inherit everything from Animal, EXCEPT: dogs are smarter--when they compute numbers, they can multiply! This is method overriding.
    class Dog : Animal
    {
        public Dog() : base()
        {
            this.covering = "fur";
        }

        public Dog(double height, double weight,string covering,string name,string sound)
        {
            this.height = height;
            this.weight = weight;
            this.covering = covering;
            this.name = name;
            this.sound = sound;
        }

        // Here is where I override the compute() method inherited from the Animal class.
        new public int compute(int num1, int num2)
        {
            return num1 * num2;
        }

        new public double compute(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Animal polly = new Animal(15, 6, "feathers", "Polly", "squawk");
            Console.WriteLine(polly.toString());
            Console.WriteLine("Polly, what is 3 + 9? " + polly.compute(3, 9));
            Console.WriteLine("Polly, what is 6.29 + 3.14? " + polly.compute(6.29, 3.14));

            Dog rover = new Dog(30, 42, "fur", "Rover", "woof");
            Console.WriteLine(rover.toString());
            Console.WriteLine("Rover, what is 3 * 9? " + rover.compute(3, 9));
            Console.WriteLine("Rover, what is 3.14 * 7.2? " + rover.compute(3.14, 7.2));

            Console.WriteLine(Animal.compute(5,5));


        }
    }
}
