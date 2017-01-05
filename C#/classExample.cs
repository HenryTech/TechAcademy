using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal() // default constructor--these values will be set if no values are given
        {
            this.height = 0; // this is used to specify whichever Animal object is being instantiated
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++; // in either default or specific case (see below), we increment numOfAnimals
        }

        public Animal(double height, double weight, string name, string sound) // constructor for when the values are given
        {
            this.height = height; // the height of the particular instance being created will equal the height given in the argument line
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0; // static fields are used with methods or properties that have nothing to do with the object, but that we need to track

        public static int getNumOfAnimals() // this is a static method--an animal will never care how many other animals there are, but we might
        {
            return numOfAnimals;
        }

        public string toString() // It's a method but we use string to declar it since it will be returning a string.
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}.", name, height, weight, sound);
        }

        // METHOD OVERLOADING: we can create two nearly identical methods, but using different data types to catch different behaviors by an object. What if the Animal could do simple sums? We would want to be able to do those on ints and on doubles both, so we use method overloading to create 2 versions of the same method for the two different cases.
        public int getSum(int num1 = 1, int num2 = 1) // It's a method that returns an int. Also, we've supplied default values in case no values are given.
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1) // Notice we already have this method defined above, but this one is for doubles, so that no matter what type of number is given the object will know how to deal with it.
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof"); // instantiating a new Animal. spot is the object, based on the Animal class
            Console.WriteLine("{0} says {1}", spot.name, spot.sound); // spot.someVar will return that aspect of the object spot
            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals()); // this is our static method, so we can see how many different Animals have been instantiated. notice that we don't use the name of any particular object for this, but the class name. since this is a static method, spot could never do it, but the class Animal can.
            Console.WriteLine(spot.toString()); // this is our public method, which prints out all of the details about the object (in this case, spot)
            // Console.WriteLine(spot.getSum()); // Since we've done function overloading, we can no longer use default values
            Console.WriteLine(spot.getSum(3, 6)); // uses the int version of the method
            Console.WriteLine(spot.getSum(1.45, 3.14)); // uses the double version of the method
            Console.WriteLine(spot.getSum(num2: 3.14, num1: 1.45)); // variable order can be changed by explicitly stating which variable contains which value
            // Another way to instantiate a new Animal by declaring the variables (instead of the way we used to instantiate spot, above).
            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrr"
            };

            Dog spike = new Dog(); // new instance of the Dog class
            Console.WriteLine(spike.toString());

            spike = new Dog(20, 15, "Spike", "Arf", "Chicken");
            Console.WriteLine(spike.toString());

        }
    }

    class Dog : Animal // creating the Dog class as a subclass of Animal
    {
        public string favFood { get; set; } // Dog is just like other Animals, but also has a favorite food.

        public Dog(): base() // This is the constructor, and with this line we say it inherits from the Animal constructor.
        {
            this.favFood = "No Favorite Food";
        }

        // This is a more elaborate constructor that allows the user to set up the various properites of Dog. I don't want to specify (as in the Animal class constructor) that each of the entry variables is equal to the corresponding class property, however, so I can use the base() method so I don't have to type all that out again. However, there is a new property--favFood. That one has to be explicitly stated.
        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }

        // I can also override inherited properties. Here I'm going to override toString() so that, when performed on a Dog it will behave differently.
        new public string toString()
        {
            return String.Format("{0} is a dog that is {1} inches tall, weighs {2} lbs and likes to say {3}. Their favorite food is {4}.", name, height, weight, sound, favFood);
        }
    }
}
