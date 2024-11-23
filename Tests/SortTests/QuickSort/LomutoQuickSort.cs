using L.Algorithms.Shared.Partition;
using L.Algorithms.Shared.PivotPicking;
using L.Algorithms;

namespace Tests.SortTests.QuickSort;

public class LomutoQuickSort
{
    public static IEnumerable<object[]> GetIntegersList() =>
        [
            [ new List<int> { 5, 2, 3, 1, 4 }, new List<int> { 1, 2, 3, 4, 5 }],
            [ new List<int> { 3, 7, 4, 25, 10 }, new List<int> { 3, 4, 7, 10, 25 } ],
            [ new List<int> { 4, 4, 3, 3, 2, 2, 1, 1}, new List<int> { 1, 1, 2, 2, 3, 3, 4, 4 } ],
        ];

    public static IEnumerable<object[]> GetDoublesList() =>
        [
            [ new List<double> { 3, 2.5, 2, 1.5, 1 }, new List<double> { 1, 1.5, 2, 2.5, 3 }],
            [ new List<double> { 2.5, 2.5, 1.5, 1.5, 0.5, 0.5 }, new List<double> { 0.5, 0.5, 1.5, 1.5, 2.5, 2.5 } ]
        ];

    public static IEnumerable<object[]> GetStringsList() =>
        [
            [ 
                new List<string> { "banana", "apple", "cherry" }, 
                new List<string> { "apple", "banana", "cherry" } 
            ],
            [ 
                new List<string> { "cherry", "apple", "cherry", "banana", "apple", "banana" } , 
                new List<string> { "apple", "apple", "banana", "banana", "cherry", "cherry"},
            ]
        ];

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void FirstPivot_IntegersList_ShouldSort(IList<int> values, IList<int> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.First);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void FirstPivot_DoublesList_ShouldSort(IList<double> values, IList<double> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.First);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void FirstPivot_StringsList_ShouldSort(IList<string> values, IList<string> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.First);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void LastPivot_IntegersList_ShouldSort(IList<int> values, IList<int> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.Last);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void LastPivot_DoublesList_ShouldSort(IList<double> values, IList<double> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.Last);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void LastPivot_StringsList_ShouldSort(IList<string> values, IList<string> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.Last);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void RandomPivot_IntegersList_ShouldSort(IList<int> values, IList<int> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.Random);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void RandomPivot_DoublesList_ShouldSort(IList<double> values, IList<double> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.Random);

        Assert.Equal(expected, values);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void RandomPivot_StringsList_ShouldSort(IList<string> values, IList<string> expected)
    {
        Sort.QuickSort(values, PartitionStrategy.Lomuto, PivotPickingStrategy.Random);

        Assert.Equal(expected, values);
    }
}
