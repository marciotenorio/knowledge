namespace ConsoleCsharp.Topics
{
    public class FloatPointPrecisionPrint
    {
        public FloatPointPrecisionPrint()
        {
            double fp = 19_000.349834D;
            Console.WriteLine($"Define float point precision in print: {fp:0.##}");
        }
    }
}
