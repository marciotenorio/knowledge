namespace ConsoleCsharp.Basics
{
    public class PrimitiveTypes
    {
        public PrimitiveTypes()
        {
            int a = default;
            long l = a;
            a = (int)l;
            float b = 1.3487F;
            double c = 10.5D;
            string d;
            bool e;
            char f;

            System.Int64 ka = 2, some = 3, somemore = 4;

            Console.WriteLine($"The age is {a}");
            Console.WriteLine($"Learning print floating points numbers: {b:0.###}");
        }
    }
}
