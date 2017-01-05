    // We can also create an abstract class.
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    // This is an interface.
    public interface ShapeItem
    {
        double area();
    }

    // Now we can create classes that inherit from our abstract class.
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        // This is an operator overload. This will allow us to add two rectangles and it returns a new rectangle.
        public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }
    }

    class Triangle : Shape
    {
        private double theBase; // Base is a C# keyword, so had to use a slightly different variable.
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }
    }
            static void Main(string[] args)
        {
            // Since we've created 2 subclasses of the abstract class "Shape", both of these count as the same data type (Shape) and, although different, are treated as the same in many cases. This is polymorphism.
            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);

            Console.WriteLine("Rect area: " + rect.area());
            Console.WriteLine("Tri area: " + tri.area());

            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("combRect area: "+combRect.area());

        }