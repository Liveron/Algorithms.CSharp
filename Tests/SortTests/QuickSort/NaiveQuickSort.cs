using L.Algorithms;
using L.Algorithms.Shared.Partition;
using L.Algorithms.Shared.PivotPicking;

namespace Tests.SortTests.QuickSort;

public class NaiveQuickSort
{
    public static IEnumerable<object[]> GetIntegersList() =>
        [
            [ new List<int> { 5, 2, 3, 1, 4 }, new List<int> { 1, 2, 3, 4, 5 }],
            [ new List<int> { 3, 7, 4, 25, 10 }, new List<int> { 3, 4, 7, 10, 25 } ],
            [ new List<int> { 4, 4, 3, 3, 2, 2, 1, 1}, new List<int> { 1, 1, 2, 2, 3, 3, 4, 4 } ],
        ];

    public static IEnumerable<object[]> GetDoublesList() =>
        [
            [ new List<double> { 3, 2.5, 2, 1.5, 1 }, new List<double> { 1, 1.5, 2, 2.5, 3 }]
        ];

    public static IEnumerable<object[]> GetStringsList() =>
        [
            [ new List<string> { "banana", "apple", "cherry" }, new List<string> { "apple", "banana", "cherry" } ]
        ];

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void FirstPivot_IntegersList_ShouldSort(IList<int> values, IList<int> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.First);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void FirstPivot_DoublesList_ShouldSort(IList<double> values, IList<double> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.First);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void FirstPivot_StringsList_ShouldSort(IList<string> values, IList<string> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.First);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void LastPivot_IntegersList_ShouldSort(IList<int> values, IList<int> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.Last);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void LastPivot_DoublesList_ShouldSort(IList<double> values, IList<double> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.Last);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void LastPivot_StringsList_ShouldSort(IList<string> values, IList<string> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.Last);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void RandomPivot_IntegersList_ShouldSort(IList<int> values, IList<int> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.Random);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void RandomPivot_DoublesList_ShouldSort(IList<double> values, IList<double> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.Random);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void RandomPivot_StringsList_ShouldSort(IList<string> values, IList<string> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Naive, PivotPickingStrategy.Random);

        Assert.Equal(expected, values);
    }
}
