    // I'm going to create an enumerative to use within my program. To do this, I have to come outside of my main class and simply declare it and give it values.
    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Now it's easy to set variables to the various elements of the enum.
            Temperature micTemp = Temperature.Low;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }