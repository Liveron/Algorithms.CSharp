using L.Algorithms;

namespace Tests.SortTests;

public class SelectionSort
{
    [Theory]
    [InlineData(new int[] { 5, 4, 3, 2, 1 })]
    public void  IntegersList_ShouldSort(IList<int> values)
    {
        IList<int> result = Sort<int>.SelectionSort(values);

        Assert.Equal(result, values.Order());
    }

    [Fact]
    public void StringList_ShouldSort()
    {
        IList<string> values = ["banana", "apple", "cherry"];

        IList<string> result = Sort<string>.SelectionSort(values);

        Assert.Equal(result, values.Order());
    }

    [Fact]
    public void EmptyList_ShouldHandle()
    {
        IList<int> values = [];

        IList<int> result = Sort<int>.SelectionSort(values);

        Assert.Empty(result);
    }

    [Fact]
    public void OneElementList_ShouldHandle()
    {
        IList<int> values = [42];

        IList<int> result = Sort<int>.SelectionSort(values);

        Assert.Equal(result, [42]);
    }

    [Fact]
    public void ListWithDuplactes_ShouldSort()
    {
        IList<int> values = [3, 3, 1, 2, 3];

        IList<int> result = Sort<int>.SelectionSort(values);

        Assert.Equal(result, values.Order());
    }
}
