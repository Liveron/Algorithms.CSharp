using L.Algorithms.Shared.Partition;
using L.Algorithms.Shared.PivotPicking;

namespace L.Algorithms;

public static partial class Select
{
    public static T QuickSelect<T>(IList<T> values, int i, PartitionStrategy partitionStrategy, 
        PivotPickingStrategy pivotPickingStrategy) where T : IComparable<T>
    {
        IPartitionStrategy partition = partitionStrategy switch
        {
            PartitionStrategy.Naive => new NaivePartition(),
            PartitionStrategy.Lomuto => throw new NotImplementedException(),
            PartitionStrategy.Hoare => throw new NotImplementedException(),
            _ => throw new NotImplementedException()
        };

        IPivotPickingStrategy pivotPicking = pivotPickingStrategy switch
        {
            PivotPickingStrategy.First => new FirstPivotPicking(),
            PivotPickingStrategy.Last => new LastPivotPicking(),
            PivotPickingStrategy.Random => new RandomPivotPicking(),
            PivotPickingStrategy.Median => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };

        return QuickSelect(0, values.Count - 1);

        T QuickSelect(int start, int end)
        {
            if (start == end) 
                return values[start];
            var (pivotIndexStart, pivotIndexEnd) = partition.Partition(values, start, end, pivotPicking);
            if (i < pivotIndexStart)
                return QuickSelect(start, pivotIndexStart - 1);
            if (i > pivotIndexEnd)
                return QuickSelect(pivotIndexEnd + 1, end);
            return values[pivotIndexStart];
        }
    }
}
