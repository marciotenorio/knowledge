namespace Lang.Basics;

/// <summary>
/// foreach don't let you modify elements because in keyword.
/// If you want modify you should use normal for.
/// </summary>
public class ForEach
{
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