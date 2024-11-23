using L.Algorithms;

namespace Tests.SortTests;

public class InsertionSort
{
    [Theory]
    [InlineData(new int[] {5, 4, 3, 2, 1})]
    public void Integers_ShouldSort(IList<int> values)
    {
        IList<int> result = Sort<int>.InsertionSort(values);

        Assert.Equal(result, values.Order());
    }

    [Fact]
    public void Strings_ShouldSort()
    {
        IList<string> values = ["banana", "apple", "cherry"];

        IList<string> result = Sort<string>.InsertionSort(values);

        Assert.Equal(result, values.Order());
    }

    [Fact]
    public void Empty_ShouldHandle()
    {
        IList<int> values = [];

        IList<int> result = Sort<int>.InsertionSort(values);

        Assert.Empty(result);
    }

    [Fact]
    public void OneElementList_ShouldHandle()
    {
        IList<int> values = [42];

        IList<int> result = Sort<int>.InsertionSort(values);

        Assert.Equal(result, [42]);
    }

    [Fact]
    public void ListWithDuplactes_ShouldSort()
    {
        IList<int> values = [3, 3, 1, 2, 3];

        IList<int> result = Sort<int>.InsertionSort(values);

        Assert.Equal(result, values.Order());
    }
}
