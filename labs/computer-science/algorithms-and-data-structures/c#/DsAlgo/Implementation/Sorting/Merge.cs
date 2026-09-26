namespace Implementation.Sorting;

public static class Merge
{
    /// <summary>
    /// Sorts the inclusive range [lower, end] of <paramref name="arr"/> in ascending
    /// order using recursive merge sort, leaving elements outside the range unchanged.
    /// </summary>
    /// <param name="arr">The array to modify. Must not be null when lower is less than end.</param>
    /// <param name="lower">The first index to sort, inclusive.</param>
    /// <param name="end">
    /// The last index to sort, inclusive, not an element count. Use arr.Length - 1
    /// to sort the whole array starting at zero, including an empty array.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="arr"/> is null and lower is less than end; copying a subrange fails.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Preconditions: For a nonempty range, 0 &lt;= lower &lt;= end &lt; arr.Length.
    /// Bounds are not validated. When lower &gt;= end, the method returns without
    /// accessing the array. Invalid bounds that enter recursion can cause exceptions;
    /// the array may already be partially modified.
    /// </para>
    /// <para>
    /// Approach: Split the range into [lower, mid] and [mid + 1, end], recursively
    /// sort both halves, then merge them. Both halves are sorted before merging.
    /// </para>
    /// <para>
    /// Complexity: For n = end - lower + 1 valid range elements with n &gt;= 2,
    /// best-, average-, and worst-case time are O(n log n). Copying and merging
    /// process O(n) elements per recursion level across O(log n) levels, assuming
    /// O(1) integer comparisons and assignments. Peak auxiliary space is O(n)
    /// for temporary arrays plus O(log n) for the call stack, hence O(n) overall.
    /// Total temporary array allocation over the execution is O(n log n).
    /// Empty and single-element ranges take O(1) time and auxiliary space.
    /// </para>
    /// <para>
    /// Properties: Stable because merging selects the left element on ties.
    /// Modifies the original array but is not in-place in the auxiliary-space sense.
    /// Not adaptive: already sorted ranges still undergo every split and merge.
    /// </para>
    /// </remarks>
    public static void Sort(int[] arr, int lower, int end)
    {
        if(lower < end)
        {
            int mid = lower + (end - lower) / 2;
            Sort(arr, lower, mid);
            Sort(arr, mid + 1, end);

            MergeArr(arr, lower, mid, end);
        }
    }

    /// <summary>
    /// Merges the adjacent sorted ranges [lower, mid] and [mid + 1, end] into
    /// ascending order within <paramref name="arr"/>, leaving other elements unchanged.
    /// </summary>
    /// <param name="arr">The non-null array containing both sorted ranges, modified by the merge.</param>
    /// <param name="lower">The inclusive start index of the left range.</param>
    /// <param name="mid">The inclusive end index of the left range.</param>
    /// <param name="end">The inclusive end index of the right range.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="arr"/> is null; copying into the temporary arrays fails.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Preconditions: 0 &lt;= lower &lt;= mid &lt; end &lt; arr.Length, and each input
    /// range must already be sorted in ascending order. These conditions are not validated.
    /// </para>
    /// <para>
    /// Approach: Copy both ranges into temporary arrays. Indices i and j track the
    /// next unread elements, while k tracks the next output position. Before each
    /// comparison, [lower, k) contains the smallest consumed elements in sorted order.
    /// Write the smaller next element, then copy the remainder when one side is exhausted.
    /// </para>
    /// <para>
    /// Complexity: For n = end - lower + 1 valid range elements, best-, average-,
    /// and worst-case time are O(n): copying and the three merge loops together
    /// process a linear number of elements. Integer comparisons and assignments
    /// take O(1) time. Auxiliary space is O(n) for two arrays whose lengths sum to n;
    /// this helper does not recurse.
    /// </para>
    /// <para>
    /// Properties: Stable because equal elements from the left range are selected
    /// before those from the right, and order within each range is preserved.
    /// Uses temporary storage even when the combined range is already sorted.
    /// </para>
    /// </remarks>
    private static void MergeArr(int[] arr, int lower, int mid, int end)
    {
        int leftSize = mid - lower + 1;
        int rightSize = end - mid;

        int[] left = new int[leftSize];
        int[] right = new int[rightSize];

        Array.Copy(arr, lower, left, 0, leftSize);
        Array.Copy(arr, mid + 1, right, 0, rightSize);

        int i = 0;
        int j = 0;
        int k = lower;
        while (i < leftSize && j < rightSize)
        {
            if(left[i] <= right[j])
            {
                arr[k] = left[i];
                ++i;
            }
            else
            {
                arr[k] = right[j];
                ++j;
            }

            ++k;
        }

        while(i < leftSize)
        {
            arr[k] = left[i];
            ++i;
            ++k;
        }
        while(j < rightSize)
        {
            arr[k] = right[j];
            ++j;
            ++k;
        }
    }
}
