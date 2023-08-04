namespace ConsoleCsharp.Basics
{
    public class Arrays
    {
        public Arrays()
        {
            //1. Array are passed as reference, not by value
            int[] arr = new int[2];
            int[] arr2 = new int[2] { 1, 2 };
            int[] arr3 = { 1, 2, 3, 4 };
            //var a = { 1,2,3}; CS0820  error
            var b1 = new[] { 1, 2, 3 };
            int[] b2 = { 1, 2, 3 };

            /* ----- Ranges ------ */
            int[] scores = { 3, 2, 5, 4, 1 };

            Console.WriteLine("scores:");
            PrintArray(scores);


            // get the first two elements
            int[] subScores = scores[..2];
            Console.WriteLine("scores[..2]:");
            PrintArray(subScores);

            // get the elements starting from the 3rd element
            subScores = scores[2..];
            Console.WriteLine("scores[2..]:");
            PrintArray(subScores);

            // get all the elements starting from the 2nd element
            Console.WriteLine("scores[1..3]:");
            subScores = scores[1..(1+2)];
            PrintArray(subScores);

            /* ----- Multidimensional Arrays ------ */
            int[,] mult = new int[2, 2]
            {
                {1,1 },
                {2,2},
            };

            int[,,] tensor =
            {
                { { 1, 2, 3 }, { 4, 5, 6 } },
                { { 7, 8, 9 }, { 10, 11, 12 } },
            };
            Console.WriteLine(tensor[0,1,1] + $"getLengh: {tensor.GetLongLength(0)}");
        }

        public void myFunc(int[] arr)
        {
            arr[0] = -1;
            arr[^1] = -1;
            Index index = ^2;
            Console.WriteLine(arr[index]);
        }

        private void PrintArray(int[] arr)
        {
            for(int i= 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Index={i};value={arr[i]}");
            }
        }
    }
}
