using L.Algorithms;
using L.Algorithms.Shared.Partition;
using L.Algorithms.Shared.PivotPicking;

namespace Tests.SelectTests.QuickSelect;

public class NaiveQuickSelect
{
    public static IEnumerable<object[]> GetIntegersList() =>
        [
            [ new List<int> { 5, 2, 3, 1, 4 }, 0, 1 ],
            [ new List<int> { 5, 2, 3, 1, 4 }, 2, 3 ],
            [ new List<int> { 4, 3, 3, 7, 1, 1, 1}, 0, 1],
            [ new List<int> { 4, 3, 3, 7, 1, 1, 1}, 4, 3]
        ];

    public static IEnumerable<object[]> GetDoublesList() =>
        [
            [ new List<double> { 3, 2.5, 2, 1.5, 1 }, 0, 1],
            [ new List<double> { 3, 2.5, 2, 1.5, 1 }, 3, 2.5],
        ];

    public static IEnumerable<object[]> GetStringsList() =>
        [
            [ new List<string> { "banana", "apple", "cherry" }, 0, "apple"],
            [ new List<string> { "banana", "apple", "cherry" }, 1, "banana"],
            [ new List<string> { "banana", "apple", "cherry" }, 2, "cherry"],
        ];

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void FirstPivot_IntegersList_ShouldSelect(IList<int> values, int index, int expected)
    {
        int result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.First);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void FirstPivot_DoublesList_ShouldSelect(IList<double> values, int index, double expected)
    {
        double result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.First);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void FirstPivot_StringsList_ShouldSelect(IList<string> values, int index, string expected)
    {
        string result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.First);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void LastPivot_IntegersList_ShouldSelect(IList<int> values, int index, int expected)
    {
        int result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.Last);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void LastPivot_DoublesList_ShouldSelect(IList<double> values, int index, double expected)
    {
        double result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.Last);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void LastPivot_StringsList_ShouldSelect(IList<string> values, int index, string expected)
    {
        string result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.Last);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetIntegersList))]
    public void RandomPivot_IntegersList_ShouldSelect(IList<int> values, int index, int expected)
    {
        int result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.Random);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetDoublesList))]
    public void RandomPivot_DoublesList_ShouldSelect(IList<double> values, int index, double expected)
    {
        double result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.Random);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetStringsList))]
    public void RandomPivot_StringsList_ShouldSelect(IList<string> values, int index, string expected)
    {
        string result = Select.QuickSelect(values, index, PartitionStrategy.Naive, PivotPickingStrategy.Random);

        Assert.Equal(expected, result);
    }
}
