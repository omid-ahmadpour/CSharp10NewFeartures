namespace CSharp10NewFeartures
{
    internal class StructureImprovements
    {
        public readonly struct Measurement
        {
            public Measurement()
            {
                Value = double.NaN;
                Description = "Undefined";
            }

            public Measurement(double value, string description)
            {
                Value = value;
                Description = description;
            }

            public double Value { get; init; }
            public string Description { get; init; }

            public override string ToString() => $"{Value} ({Description})";
        }

        public static void Main()
        {
            var m1 = new Measurement();
            Console.WriteLine(m1);  // output: NaN (Undefined)

            var m2 = default(Measurement);
            Console.WriteLine(m2);  // output: 0 ()

            var ms = new Measurement[2];
            Console.WriteLine(string.Join(", ", ms));  // output: 0 (), 0 ()
        }
    }
}
