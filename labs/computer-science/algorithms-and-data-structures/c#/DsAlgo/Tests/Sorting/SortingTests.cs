using Implementation.Sorting;

namespace Tests.Sorting;

public class SortingTests
{
    #region Selection sort

    [Theory]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 7 }, new[] { 7 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 6, 4, 5, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new[] { 3, 1, 3, 2, 1 }, new[] { 1, 1, 2, 3, 3 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 2, 2, 2 })]
    [InlineData(new[] { 0, -3, 2, -1 }, new[] { -3, -1, 0, 2 })]
    [InlineData(new[] { int.MaxValue, 0, int.MinValue }, new[] { int.MinValue, 0, int.MaxValue })]
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
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 7 }, new[] { 7 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 6, 4, 5, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new[] { 3, 1, 3, 2, 1 }, new[] { 1, 1, 2, 3, 3 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 2, 2, 2 })]
    [InlineData(new[] { 0, -3, 2, -1 }, new[] { -3, -1, 0, 2 })]
    [InlineData(new[] { int.MaxValue, 0, int.MinValue }, new[] { int.MinValue, 0, int.MaxValue })]
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
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 7 }, new[] { 7 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 6, 4, 5, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new[] { 3, 1, 3, 2, 1 }, new[] { 1, 1, 2, 3, 3 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 2, 2, 2 })]
    [InlineData(new[] { 0, -3, 2, -1 }, new[] { -3, -1, 0, 2 })]
    [InlineData(new[] { int.MaxValue, 0, int.MinValue }, new[] { int.MinValue, 0, int.MaxValue })]
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
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 7 }, new[] { 7 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 6, 4, 5, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new[] { 3, 1, 3, 2, 1 }, new[] { 1, 1, 2, 3, 3 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 2, 2, 2 })]
    [InlineData(new[] { 0, -3, 2, -1 }, new[] { -3, -1, 0, 2 })]
    [InlineData(new[] { int.MaxValue, 0, int.MinValue }, new[] { int.MinValue, 0, int.MaxValue })]
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
}