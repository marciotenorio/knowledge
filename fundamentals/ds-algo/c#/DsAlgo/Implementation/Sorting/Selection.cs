namespace Implementation.Sorting;

public static class Selection
{
    //TODO
    public static void Sort(int[] arr, int size)
    {
        ArgumentNullException.ThrowIfNull(arr);

        for(int i=0; i<size; i++)
        {
            int currentLower = i;

            for(int j=i+1; j<size; j++)
            {
                if(arr[j] < arr[currentLower]) currentLower = j;
            }

            (arr[currentLower], arr[i]) = (arr[i], arr[currentLower]);
        }
    }

}
