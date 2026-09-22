namespace Implementation.Sorting;

public static class Bubble
{
    /// <summary>
    /// Sorts the first <paramref name="size"/> elements of <paramref name="arr"/>
    /// in ascending order using bubble sort. Modifies the array in place and leaves
    /// elements beyond this prefix unchanged.
    /// </summary>
    /// <param name="arr">The array to modify. Must not be null.</param>
    /// <param name="size">
    /// The number of elements to sort, from zero through the array length.
    /// This range is required but is not validated.
    /// </param>
    /// <exception cref="ArgumentNullException"><paramref name="arr"/> is null.</exception>
    /// <exception cref="IndexOutOfRangeException">
    /// <paramref name="size"/> exceeds the array length and is greater than one.
    /// Some elements may already have been swapped before the exception occurs.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Approach: Scan adjacent pairs from left to right, swapping them when the left
    /// value is larger. Each pass moves the largest remaining value to the end of the
    /// unsorted portion. The next pass skips that position because it is already final.
    /// If a full pass makes no swaps, the prefix is sorted and the method returns early.
    /// </para>
    /// <para>
    /// Complexity: Let n be the number of elements in the valid prefix. Best-case time
    /// is O(n) for already sorted input, since one pass makes no swaps. Average-case
    /// time is O(n²) for uniformly random permutations of distinct values; worst-case
    /// time is O(n²), reached by reverse-sorted distinct values. At most n(n - 1)/2
    /// adjacent comparisons are made. Each integer comparison and swap takes O(1)
    /// time. Auxiliary space is O(1).
    /// </para>
    /// <para>
    /// Properties: In-place and stable: equal values are never swapped, so they retain
    /// their relative order. The early exit adapts the work to existing order.
    /// Empty and single-element prefixes require no comparisons or swaps after the
    /// null check.
    /// </para>
    /// </remarks>
    public static void Sort(int[] arr, int size)
    {
        ArgumentNullException.ThrowIfNull(arr);

        for (int i = 0; i < size - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < (size - i - 1); j++)
            {
                if(arr[j] > arr[j+1])
                {
                    (arr[j+1], arr[j]) = (arr[j], arr[j+1]);
                    swapped = true;
                }
            }

            if(!swapped)
                return;
        }
    }
}
