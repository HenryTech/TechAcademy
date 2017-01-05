        static void Main(string[] args)
        {
            // We created a generic class below, with no data types specified, so when we instantiate it we have to then specify those data types.
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");

            samsungTV.key = 12345;
            samsungTV.value = "50-inch Samsung TV";

            superman.showData();
            samsungTV.showData();

        }

        // Generic classes do not specify data types, and can work with any data type.
        class KeyValue<TKey, TValue>
        {
            public TKey key { get; set; }
            public TValue value { get; set; }

            public KeyValue(TKey k, TValue v)
            {
                key = k;
                value = v;
            }

            public void showData()
            {
                Console.WriteLine("{0} is {1}.", this.key, this.value);
            }

        }