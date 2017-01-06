            StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentence.");
            sb.AppendLine(); // this adds a line break to the stringbuilder string
            sb.AppendFormat("My name is {0} and I live in {1}.", "Sean", "Portland");
            sb.Replace("a", "e"); // replaces all "a" with "e"
            sb.Remove(5, 7); // removes characters at index 5 and 6 (stops at 7 but does not include it)
            Console.WriteLine(sb.ToString()); // In order to print whatever we've created in stringbuilder, we have to first turn it in to an actual string with ToString.
            sb.Clear(); // gets rid of the contents of sb