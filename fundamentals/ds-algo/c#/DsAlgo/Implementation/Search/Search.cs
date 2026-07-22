namespace Implementation.Search;

public static class SearchAlgos
{
    /// <summary>
    /// Find the value and return the corresponding index from array.
    /// The array must be in ascending order. Valid bounds
    /// <paramref name="begin"/> and <paramref name="last"/>
    /// should be provided.
    /// </summary>
    /// <remarks>
    /// This method intentionally does not validate the supplied bounds.
    /// The caller must ensure that the array is not null, that the range is
    /// accessible, and that its elements are sorted in ascending order.
    /// Behavior is unspecified when these preconditions are violated.
    /// In C#, an invalid array access may throw
    /// <see cref="IndexOutOfRangeException"/>.
    /// </remarks>
    /// <param name="value">The value will be searched for.</param>
    /// <param name="arr">The array used on search.</param>
    /// <param name="start">Begin of array (inclusive).</param>
    /// <param name="end">End of array (inclusive)</param>
    /// <returns>Index of value in array. Otherwise, -1.</returns>
    public static int BinarySearch(int value, int[] arr, int begin, int last)
    {
        ArgumentNullException.ThrowIfNull(arr);

        while(begin <= last)
        {
            int middle = begin + (last - begin) / 2;

            if(arr[middle] == value) return middle;
            if(value > arr[middle]) begin = middle + 1;
            else last = middle - 1;
        }

        return -1;
    }
}