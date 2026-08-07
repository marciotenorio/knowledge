using Implementation.Sorting;

namespace Tests.Sorting;

public class SortingTests
{
    //1, 1, 2, 3
    private static bool ValidateSorting(int[] arr)
    {
        bool ascending = true;
        bool descending = true;

        for (int i = 1; i < arr.Length; i++)
        {
            if(arr[i] < arr[i - 1]) descending = false;
            if(arr[i] > arr[i - 1]) ascending  = false;
            if(!ascending && !descending) return false;
        }

        return true;
    }

    [Fact]
    public void Arr_CorrectSorting_ReturnAsceding()
    {
        int[] arr = new int[6] {6, 4, 5, 3, 2, 1};
        Selection.Sort(arr, 6);
        Assert.True(ValidateSorting(arr));
    }

    [Fact]
    public void EmptyArr_DoNothing_ReturnEmpty()
    {
        int[] empty = new int[0];
        Selection.Sort(empty, 0);
        Assert.True(ValidateSorting(empty));
    }
}
