namespace Tests.Search;

public class BinarySearchTests
{
    private readonly int[] _oddArr = new int[11] {1, 4, 6, 8, 9, 11, 13, 15, 15, 15, 19};
    private readonly int[] _evenArr = new int[10] {1, 4, 6, 8, 9, 11, 13, 15, 23, 25};
    private readonly int[] _oneArray = new int[1] { 99 };
    private readonly int[] _emptyArr = new int[0] {};

    [Fact]
    public void EvenArr_Exists_Return9()
    {
        int index = SearchAlgos.BinarySearch(25, _evenArr, 0, 9);

        Assert.Equal(9, index);
    }

    [Fact]
    public void EvenArr_NotExists_ReturnMinus1()
    {
        int index = SearchAlgos.BinarySearch(99, _evenArr, 0, 9);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void EvenArr_ExistsInMiddle_Return4()
    {
        int index = SearchAlgos.BinarySearch(9, _evenArr, 0, 9);

        Assert.Equal(4, index);
    }

    [Fact]
    public void EvenArr_ExistsInBegin_Return0()
    {
        int index = SearchAlgos.BinarySearch(1, _evenArr, 0, 9);

        Assert.Equal(0, index);
    }

    [Fact]
    public void OddArr_Exists_Return3()
    {
        int index = SearchAlgos.BinarySearch(8, _oddArr, 0, 9);

        Assert.Equal(3, index);
    }

    [Fact]
    public void OddArr_NotExists_ReturnMinus1()
    {
        int index = SearchAlgos.BinarySearch(99, _oddArr, 0, 9);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void OddArr_ExistsInMiddle_Return5()
    {
        int index = SearchAlgos.BinarySearch(11, _oddArr, 0, 10);
        Assert.Equal(5, index);
    }

    [Fact]
    public void OddArr_ExistsInBegin_Return0()
    {
        int index = SearchAlgos.BinarySearch(1, _oddArr, 0, 9);

        Assert.Equal(0, index);
    }

    [Fact]
    public void OddArr_ExistsInEnd_Return10()
    {
        int index = SearchAlgos.BinarySearch(19, _oddArr, 0, 10);

        Assert.Equal(10, index);
    }

    [Fact]
    public void OneArray_Exists_Return0()
    {
        int index = SearchAlgos.BinarySearch(99, _oneArray, 0, 0);

        Assert.Equal(0, index);
    }

    [Fact]
    public void OneArray_NotExists_ReturnMinus1()
    {
        int index = SearchAlgos.BinarySearch(100, _oneArray, 0, 0);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void NullArray_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            SearchAlgos.BinarySearch(1, null!, -1, 100));
    }

    [Fact]
    public void EmptyRange_ReturnsMinus1()
    {
        int index = SearchAlgos.BinarySearch(1, _emptyArr, 0, -1);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void ValueOutsideSuppliedRange_ReturnsMinus1()
    {
        int index = SearchAlgos.BinarySearch(25, _evenArr, 0, 8);

        Assert.Equal(-1, index);
    }
}
