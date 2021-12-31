namespace RecordStructSample
{
    internal class RecordStructDemo
    {
        // positional parameters syntax
        public readonly record struct Point(double X, double Y, double Z);

        // standard property syntax
        public record struct Point2
        {
            public double X { get; init; }
            public double Y { get; init; }
            public double Z { get; init; }
        }
    }
}
