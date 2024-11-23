using L.Algorithms;

namespace Tests.SearchTests;

public class BinarySearch
{
    static readonly List<int> IntegersList = [1, 2, 3, 4, 5, 6];
    static readonly List<double> DoublesList = [1, 1.5, 2, 2.5, 3, 3.5];
    static readonly List<string> StringsList = ["apple", "banana", "cherry"];

    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    public void IntegersList_ShouldSearch(int element, int expected)
    {
        int result = Search.BinarySearch(IntegersList, element);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(1.5, 1)]
    [InlineData(2, 2)]
    public void DoublesList_ShouldSearch(double element, int expected)
    {
        int result = Search.BinarySearch(DoublesList, element);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("apple", 0)]
    [InlineData("banana", 1)]
    [InlineData("cherry", 2)]
    public void StringsList_ShouldSearch(string element, int expected)
    {
        int result = Search.BinarySearch(StringsList, element);
        Assert.Equal(expected, result);
    }
}
