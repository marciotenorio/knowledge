using Implementation.Sorting;

namespace Tests.Sorting;

public class SortingTests
{
    /// <summary>
    /// Input and expected output shared by every sorting algorithm. The property
    /// builds new arrays on each access because the sorts modify them in place.
    /// </summary>
    public static TheoryData<int[], int[]> UnsortedAndSorted => new()
    {
        { [], [] },
        { [7], [7] },
        { [1, 2], [1, 2] },
        { [2, 1], [1, 2] },
        { [1, 2, 3, 4], [1, 2, 3, 4] },
        { [4, 3, 2, 1], [1, 2, 3, 4] },
        { [6, 4, 5, 3, 2, 1], [1, 2, 3, 4, 5, 6] },
        { [1, 3, 2, 5, 4], [1, 2, 3, 4, 5] },
        { [3, 1, 3, 2, 1], [1, 1, 2, 3, 3] },
        { [2, 2, 2], [2, 2, 2] },
        { [0, -3, 2, -1], [-3, -1, 0, 2] },
        { [int.MaxValue, 0, int.MinValue], [int.MinValue, 0, int.MaxValue] },
    };
    #region Selection sort

    [Theory]
    [MemberData(nameof(UnsortedAndSorted))]
    public void Selection_Sort_ReturnsAscendingValues(int[] arr, int[] expected)
    {
        Selection.Sort(arr, arr.Length);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void Selection_SortPrefix_LeavesRemainingValuesUnchanged()
    {
        int[] arr = [4, 2, 3, 1, 0, -1];

        Selection.Sort(arr, 3);

        Assert.Equal(new[] { 2, 3, 4, 1, 0, -1 }, arr);
    }

    [Fact]
    public void Selection_SortZeroElements_LeavesArrayUnchanged()
    {
        int[] arr = [3, 1, 2];

        Selection.Sort(arr, 0);

        Assert.Equal(new[] { 3, 1, 2 }, arr);
    }

    #endregion

    #region Insertion sort

    [Theory]
    [MemberData(nameof(UnsortedAndSorted))]
    public void Insertion_Sort_ReturnsAscendingValues(int[] arr, int[] expected)
    {
        Insertion.Sort(arr, arr.Length);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void Insertion_SortPrefix_LeavesRemainingValuesUnchanged()
    {
        int[] arr = [4, 2, 3, 1, 0, -1];

        Insertion.Sort(arr, 3);

        Assert.Equal(new[] { 2, 3, 4, 1, 0, -1 }, arr);
    }

    [Fact]
    public void Insertion_SortZeroElements_LeavesArrayUnchanged()
    {
        int[] arr = [3, 1, 2];

        Insertion.Sort(arr, 0);

        Assert.Equal(new[] { 3, 1, 2 }, arr);
    }

    #endregion

    #region Bubble Sort

    [Theory]
    [MemberData(nameof(UnsortedAndSorted))]
    public void Bubble_Sort_ReturnsAscendingValues(int[] arr, int[] expected)
    {
        Bubble.Sort(arr, arr.Length);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void Bubble_SortPrefix_LeavesRemainingValuesUnchanged()
    {
        int[] arr = [4, 2, 3, 1, 0, -1];

        Bubble.Sort(arr, 3);

        Assert.Equal(new[] { 2, 3, 4, 1, 0, -1 }, arr);
    }

    [Fact]
    public void Bubble_SortZeroElements_LeavesArrayUnchanged()
    {
        int[] arr = [3, 1, 2];

        Bubble.Sort(arr, 0);

        Assert.Equal(new[] { 3, 1, 2 }, arr);
    }

    #endregion

    #region Merge Sort

    [Theory]
    [MemberData(nameof(UnsortedAndSorted))]
    public void Merge_Sort_ReturnsAscendingValues(int[] arr, int[] expected)
    {
        Merge.Sort(arr, 0, arr.Length - 1);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void Merge_SortPrefix_LeavesRemainingValuesUnchanged()
    {
        int[] arr = [4, 2, 3, 1, 0, -1];

        Merge.Sort(arr, 0, 2);

        Assert.Equal(new[] { 2, 3, 4, 1, 0, -1 }, arr);
    }

    [Fact]
    public void Merge_SortZeroElements_LeavesArrayUnchanged()
    {
        int[] arr = [3, 1, 2];

        Merge.Sort(arr, 0, -1);

        Assert.Equal(new[] { 3, 1, 2 }, arr);
    }

    #endregion

    #region Quick Sort

    [Theory]
    [MemberData(nameof(UnsortedAndSorted))]
    public void Quick_Sort_ReturnsAscendingValues(int[] arr, int[] expected)
    {
        Quick.Sort(arr, 0, arr.Length - 1);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void Quick_SortPrefix_LeavesRemainingValuesUnchanged()
    {
        int[] arr = [4, 2, 3, 1, 0, -1];

        Quick.Sort(arr, 0, 2);

        Assert.Equal(new[] { 2, 3, 4, 1, 0, -1 }, arr);
    }

    [Fact]
    public void Quick_SortMiddleRange_LeavesOuterValuesUnchanged()
    {
        int[] arr = [9, 5, 1, 4, 2, -1];

        Quick.Sort(arr, 1, 4);

        Assert.Equal(new[] { 9, 1, 2, 4, 5, -1 }, arr);
    }

    [Fact]
    public void Quick_SortZeroElements_LeavesArrayUnchanged()
    {
        int[] arr = [3, 1, 2];

        Quick.Sort(arr, 0, -1);

        Assert.Equal(new[] { 3, 1, 2 }, arr);
    }

    /// <summary>
    /// Inputs that make the last-element pivot and the Lomuto partition degrade to
    /// O(n^2) time and O(n) recursion depth. The size stays small because much larger
    /// inputs overflow the stack with the classic implementation.
    /// </summary>
    public static TheoryData<string> WorstCaseInputs => new()
    {
        "sorted",
        "reversed",
        "all equal",
    };

    [Theory]
    [MemberData(nameof(WorstCaseInputs))]
    public void Quick_SortWorstCaseInput_ReturnsAscendingValues(string kind)
    {
        const int size = 2_000;
        int[] arr = kind switch
        {
            "sorted" => Enumerable.Range(0, size).ToArray(),
            "reversed" => Enumerable.Range(0, size).Reverse().ToArray(),
            _ => Enumerable.Repeat(5, size).ToArray(),
        };
        int[] expected = arr.Order().ToArray();

        Quick.Sort(arr, 0, arr.Length - 1);

        Assert.Equal(expected, arr);
    }

    #endregion
}