namespace RecordStructSample
{
    internal class RecordDemo
    {
        public record Person(string FirstName, string LastName); // immutable properties with positional params

        public record Person1 // immutable properties with standard property syntax
        {
            public string FirstName { get; init; } = default!;
            public string LastName { get; init; } = default!;
        };

        public record Person2 // Mutable properties 
        {
            public string FirstName { get; set; } = default!;
            public string LastName { get; set; } = default!;
        };

        public static void Main()
        {
            var p = new Person("Kaushik", "Roy");
            //p.FirstName = "Tim";
            //Console.WriteLine(p.FirstName + " " + p.LastName);

            var p1 = new Person1 { FirstName = "John", LastName = "William" };
            //p1.FirstName = "Henry";

            var p2 = new Person2 { FirstName = "Robbie", LastName = "William" };
            Console.WriteLine(p2.FirstName + " " + p2.LastName);

            p2.FirstName = "John"; p2.LastName = "George";
            Console.WriteLine(p2.FirstName + " " + p2.LastName);
        }
    }
}
