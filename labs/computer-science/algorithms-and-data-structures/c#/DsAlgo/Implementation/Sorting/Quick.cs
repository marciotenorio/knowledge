namespace Implementation.Sorting;

public static class Quick
{
    /// <summary>
    /// Sorts the inclusive range [begin, endInclusive] of <paramref name="arr"/> in
    /// ascending order using classic quick sort: the last element is the pivot and the
    /// range is split with a Lomuto partition. The array is modified in place; elements
    /// outside the range are left unchanged.
    /// </summary>
    /// <param name="arr">The array to modify. Must not be null when begin is less than endInclusive.</param>
    /// <param name="begin">The first index to sort, inclusive.</param>
    /// <param name="endInclusive">
    /// The last index to sort, inclusive, not an element count. Use arr.Length - 1
    /// to sort the whole array starting at zero, including an empty array.
    /// </param>
    /// <exception cref="NullReferenceException">
    /// <paramref name="arr"/> is null and begin is less than endInclusive. The argument
    /// is not checked; the exception comes from the first array access.
    /// </exception>
    /// <exception cref="IndexOutOfRangeException">
    /// The range is nonempty and not inside the array. Bounds are not checked, so
    /// the array may already be partially rearranged when this is thrown.
    /// </exception>
    /// <exception cref="StackOverflowException">
    /// Large inputs that hit the worst case, such as an already sorted array of about
    /// a million elements, recurse about n levels deep. This ends the process and
    /// cannot be caught.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Preconditions: For a nonempty range, 0 &lt;= begin &lt;= endInclusive &lt; arr.Length.
    /// Bounds are not validated. When begin &gt;= endInclusive, the range has zero or
    /// one element and the method returns without accessing the array.
    /// </para>
    /// <para>
    /// Approach: Divide and conquer, with the work done before the split instead of
    /// after it, the opposite of merge sort. <see cref="Partition"/> places the pivot in
    /// its final sorted position, with smaller values to its left and the rest to its
    /// right: [begin, pivotIndex) &lt; pivot &lt;= (pivotIndex, endInclusive]. The two
    /// sides are then sorted recursively, and nothing has to be combined afterwards,
    /// because every element of the left side already belongs before every element of
    /// the right side. Each side excludes the pivot, so the ranges always shrink.
    /// </para>
    /// <para>
    /// Complexity: Let n = endInclusive - begin + 1, and assume integer comparisons and
    /// swaps take O(1) time. Each call to <see cref="Partition"/> takes linear time in
    /// its range, so the total time depends on how evenly the pivots split.
    /// Best and average case, O(n log n): when pivots land near the middle, the
    /// recursion is O(log n) levels deep with O(n) work per level. The average assumes
    /// distinct values with every input order equally likely; under that assumption
    /// the last element is a random pick, and the expected number of comparisons is
    /// about 1.39 n log2 n.
    /// Worst case, O(n^2): the pivot is always the largest or smallest value, so each
    /// split is n - 1 / 0 and the work is (n - 1) + (n - 2) + ... + 1. This happens on
    /// common inputs: already sorted (the last element is the maximum), reverse
    /// sorted (it is the minimum) and all values equal (no value is smaller than the
    /// pivot, so the pivot moves to begin every time).
    /// Auxiliary space is the call stack only: O(log n) in the best and average cases
    /// and O(n) in the worst case. No temporary arrays are allocated, and the input
    /// array is not counted. Ranges with zero or one element take O(1) time and space.
    /// </para>
    /// <para>
    /// Properties: Not stable, because <see cref="Partition"/> swaps elements over long
    /// distances and can move them past equal keys. This is invisible for plain ints but
    /// matters when sorting records by a key. In place: only [begin, endInclusive] is
    /// rearranged. Not adaptive, and worse than that, already sorted input is its worst
    /// case. Deterministic: the same input always produces the same swaps.
    /// </para>
    /// <para>
    /// Possible improvement, recurse on the smaller side first: replace the if with a
    /// while loop, make the recursive call only for the smaller side, and continue the
    /// loop with the larger side by moving begin or endInclusive (manual tail-call
    /// elimination). Each recursive call then gets at most half of the range, so the
    /// stack depth is at most log2 n in every case, which removes the
    /// StackOverflowException even when the time is still O(n^2). See
    /// <see cref="Partition"/> for improvements to the pivot and the partition.
    /// </para>
    /// </remarks>
    public static void Sort(int[] arr, int begin, int endInclusive)
    {
        if(begin < endInclusive)
        {
            int pivotIndex = Partition(arr, begin, endInclusive);
            Sort(arr, begin, pivotIndex - 1);
            Sort(arr, pivotIndex + 1, endInclusive);
        }
    }

    /// <summary>
    /// Lomuto partition: uses arr[endInclusive] as the pivot and rearranges the
    /// inclusive range [begin, endInclusive] of <paramref name="arr"/> so that values
    /// smaller than the pivot come first, then the pivot, then the remaining values.
    /// Modifies the array in place; elements outside the range are left unchanged.
    /// </summary>
    /// <param name="arr">The non-null array containing the range.</param>
    /// <param name="begin">The first index of the range, inclusive.</param>
    /// <param name="endInclusive">
    /// The last index of the range, inclusive, not an element count. Its element is the pivot.
    /// </param>
    /// <returns>
    /// The final index of the pivot, an absolute index into <paramref name="arr"/> with
    /// begin &lt;= result &lt;= endInclusive. Afterwards [begin, result) &lt; pivot and
    /// (result, endInclusive] &gt;= pivot. Either side may be empty.
    /// </returns>
    /// <exception cref="NullReferenceException">
    /// <paramref name="arr"/> is null. Not checked; only possible if the preconditions are violated.
    /// </exception>
    /// <exception cref="IndexOutOfRangeException">
    /// The range is not inside the array. Not checked; the array may already be
    /// partially rearranged when this is thrown.
    /// </exception>
    /// <remarks>
    /// <para>
    /// Preconditions: 0 &lt;= begin &lt;= endInclusive &lt; arr.Length. Not validated.
    /// <see cref="Sort"/> only calls this for ranges with at least two elements.
    /// </para>
    /// <para>
    /// Approach: The pivot value is copied from the last position. Index k scans
    /// [begin, endInclusive) once, keeping this invariant before each step:
    /// [begin, i) &lt; pivot, [i, k) &gt;= pivot and [k, endInclusive) is not yet examined.
    /// When arr[k] is smaller than the pivot, it is swapped with arr[i], the first
    /// value that is not smaller, and i advances, growing the smaller block by one.
    /// After the scan, i is the first position of the not-smaller block, so swapping
    /// arr[i] with the pivot at endInclusive puts the pivot between the two blocks.
    /// </para>
    /// <para>
    /// Complexity: Let n = endInclusive - begin + 1. Best, average and worst-case time
    /// are all O(n): the loop runs exactly n - 1 times with one integer comparison
    /// each, plus at most n - 1 swaps in the loop and one final swap. Auxiliary space
    /// is O(1): a few local indices and no recursion.
    /// </para>
    /// <para>
    /// Properties: Not stable. Swaps move values that are not smaller than the pivot
    /// forward, past other elements, and the final swap moves arr[i] to the end of the
    /// range. For example, with equal keys 2a and 2b, [2a, 2b, 1] becomes [1, 2b, 2a].
    /// In place, modifying only [begin, endInclusive]. Values equal to the pivot all
    /// end up on the right side, which is why all-equal input is a worst case.
    /// </para>
    /// <para>
    /// Possible improvement, better pivot: the last element is the maximum of sorted
    /// input and the minimum of reverse-sorted input, giving n - 1 / 0 splits. Swapping
    /// a randomly chosen element (for example Random.Shared.Next(begin, endInclusive + 1))
    /// into endInclusive before partitioning gives expected O(n log n) time for every
    /// input; the expectation is then over the random choices, not over the input.
    /// Median-of-three (the median of the first, middle and last elements) is a
    /// deterministic alternative that also handles sorted input, but inputs can be
    /// crafted to defeat it.
    /// </para>
    /// <para>
    /// Possible improvement, three-way partition (Dijkstra's Dutch national flag):
    /// return the bounds (lt, gt) of a middle block with every value equal to the pivot,
    /// so that [begin, lt) &lt; pivot, [lt, gt] == pivot and (gt, endInclusive] &gt; pivot.
    /// Three indices scan once: a smaller arr[i] is swapped to lt and both lt and i
    /// advance; a greater arr[i] is swapped to gt and only gt moves back, because the
    /// value arriving at i is still unexamined; an equal arr[i] only advances i. Sort
    /// then recurses on [begin, lt - 1] and [gt + 1, endInclusive], skipping all values
    /// equal to the pivot. All-equal input becomes a single O(n) pass instead of O(n^2),
    /// and many duplicates make the sort faster instead of slower.
    /// </para>
    /// </remarks>
    private static int Partition(int[] arr, int begin, int endInclusive)
    {
        int pivotValue = arr[endInclusive];
        int i = begin;

        for (int k = begin; k < endInclusive; k++)
        {
            if(arr[k] < pivotValue)
            {
                (arr[i], arr[k]) = (arr[k], arr[i]);
                i++;
            }
        }

        (arr[i], arr[endInclusive]) = (arr[endInclusive], arr[i]);
        return i;
    }
}
