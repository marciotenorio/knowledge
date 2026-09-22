namespace Implementation.Sorting;

public static class Selection
{
    /// <summary>
    /// Sorts the first <paramref name="size"/> elements of <paramref name="arr"/>
    /// in ascending order using in-place selection sort, leaving the remaining elements unchanged.
    /// </summary>
    /// <param name="arr">The array to modify. Must not be null.</param>
    /// <param name="size">
    /// The length of the prefix to sort, normally between zero and the array length.
    /// This range is not validated; nonpositive values leave the array unchanged.
    /// </param>
    /// <exception cref="ArgumentNullException"><paramref name="arr"/> is null.</exception>
    /// <exception cref="IndexOutOfRangeException">
    /// <paramref name="size"/> exceeds the array length.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Approach: Each pass finds the minimum element in the unsorted prefix remainder
    /// and swaps it into the next position. Before each pass, the preceding positions
    /// contain the smallest elements in sorted order.
    /// </para>
    /// <para>
    /// Complexity: For n = size valid prefix elements, best, average, and worst-case
    /// time are O(n²). The method performs n(n - 1)/2 integer comparisons and n swaps,
    /// including self-swaps, regardless of the initial ordering. Auxiliary space is O(1).
    /// </para>
    /// <para>
    /// Properties: In-place and not adaptive to existing order. The sort is unstable
    /// because a swap can move an element past another element with an equal value.
    /// Empty prefixes require no work after the null check.
    /// </para>
    /// </remarks>
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
