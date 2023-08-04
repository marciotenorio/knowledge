namespace ConsoleCsharp.Basics
{
    public class ForEach
    {
        //foreach don't let you modify elements because in keyword
        //if you want modify you should use normal for

        public ForEach()
        {
            int[,] matrix =
            {
                {1,2,3 },
                {4,5,6 }
            };

            foreach (var e in matrix)
            {
                Console.Write($"{e} ");
            }
        }
    }
}
