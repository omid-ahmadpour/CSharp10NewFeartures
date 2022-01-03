namespace StructTypeImprovementSample
{
    internal class StructWithOperation
    {
        public struct NamedPoint
        {
            public NamedPoint()
            {
                Name = string.Empty;
                ValueX = 0;
                ValueY = 0;
            }

            public NamedPoint(string name, int x, int y)
            {
                Name = name;
                ValueX = x;
                ValueY = y;
            }

            public string Name { get; init; }
            public int ValueX { get; init; }
            public int ValueY { get; init; }
        }



        public static void Main()
        {
            var p1 = new NamedPoint("A", 0, 0);
            Console.WriteLine($"{nameof(p1)}: {p1.Name},{p1.ValueX},{p1.ValueY}");  
            // output: p1: NamedPoint { Name = A, X = 0, Y = 0 }

            var p2 = p1 with { Name = "B", ValueX = 5 };
            Console.WriteLine($"{nameof(p2)}: {p2.Name},{p2.ValueX},{p2.ValueY}");  
            // output: p2: NamedPoint { Name = B, X = 5, Y = 0 }

            var p3 = p1 with
            {
                Name = "C",
                ValueY = 4
            };
            Console.WriteLine($"{nameof(p3)}: {p3.Name},{p3.ValueX},{p3.ValueY}");  // output: p3: NamedPoint { Name = C, X = 0, Y = 4 }

            var NamedPoint1 = new
            {
                Name = "Rory",
                X = 100,
                Y = 200
            };
            var NamedPoint2 = NamedPoint1 with { Name = "Johnny", X = 300 };
            Console.WriteLine(NamedPoint1);
            Console.WriteLine(NamedPoint2);
        }
    }
}
