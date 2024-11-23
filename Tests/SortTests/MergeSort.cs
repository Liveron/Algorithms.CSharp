using L.Algorithms;

namespace Tests.SortTests;

public class MergeSort
{
    [Theory]
    [InlineData(new int[] { 5, 4, 3, 2, 1 })]
    public void ShouldSortUnsortedArray(int[] input)
    {
        IList<int> result = Sort<int>.MergeSort(input);

        Assert.Equal(result, input.Order());
    }

    [Fact]
    public void ShouldHandleEmptyArray()
    {
        int[] input = [];

        IList<int> result = Sort<int>.MergeSort(input);

        Assert.Equal(result, []);
    }

    [Fact]
    public void ShouldHandleSingleElementArray()
    {
        int[] input = [1];

        IList<int> result = Sort<int>.MergeSort(input);

        Assert.Equal(result, [1]);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5})]
    public void ShouldHandleSortedArray(int[] input)
    {
        IList<int> result = Sort<int>.MergeSort(input);

        Assert.Equal(result, input);
    }
}
