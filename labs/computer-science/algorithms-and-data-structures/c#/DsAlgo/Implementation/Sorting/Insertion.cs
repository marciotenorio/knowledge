namespace Implementation.Sorting;

public static class Insertion
{

    /// <summary>
    /// Sorts the first <paramref name="size"/> elements of <paramref name="arr"/>
    /// in ascending order using in-place insertion sort, leaving the remaining elements unchanged.
    /// </summary>
    /// <param name="arr">The array to modify. Must not be null when elements are accessed.</param>
    /// <param name="size">
    /// The length of the prefix to sort. Expected to be between zero and the array length;
    /// this range is not validated. Values less than or equal to one perform no work.
    /// </param>
    /// <exception cref="NullReferenceException">
    /// <paramref name="arr"/> is null and <paramref name="size"/> is greater than one.
    /// </exception>
    /// <exception cref="IndexOutOfRangeException">
    /// <paramref name="size"/> is greater than one and exceeds the length of a non-null array.
    /// The array may already be partially sorted when the exception occurs.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Approach: Before each pass, the elements preceding index i are sorted.
    /// Save the value at i, shift larger preceding values one position right, and
    /// insert the saved value into the resulting gap at j + 1. If no shift is needed,
    /// the final assignment writes the saved value back to its original position.
    /// </para>
    /// <para>
    /// Complexity: For n = size valid prefix elements, best-case time is O(n) for
    /// already sorted input. Average-case time is O(n²) for uniformly random permutations
    /// of distinct values; worst-case time is O(n²), reached by reverse-sorted distinct
    /// values. Each pass can shift every preceding element. Integer comparisons and
    /// assignments take O(1) time, and auxiliary space is O(1).
    /// </para>
    /// <para>
    /// Properties: In-place, stable, and adaptive to existing order. Only strictly larger
    /// values shift, so equal values retain their relative order. Fewer out-of-order pairs
    /// require fewer shifts. Empty and single-element prefixes need no changes.
    /// </para>
    /// </remarks>
    public static void Sort(int[] arr, int size)
    {
        ArgumentNullException.ThrowIfNull(arr);
        
        for (int i = 1; i < size; i++)
        {
            int currentUnsortedItem = arr[i];
            int j = i-1;

            while (j>=0 && arr[j] > currentUnsortedItem)
            {
                arr[j+1] = arr[j];
                --j;
            }

            arr[j+1] = currentUnsortedItem;
        }   
    }
}
