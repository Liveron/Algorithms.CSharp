using L.Algorithms.Shared.Partition;
using L.Algorithms.Shared.PivotPicking;

namespace L.Algorithms;

public static partial class Sort
{
    public static void QuickSort<T>(
        IList<T> values, PartitionStrategy partitionStrategy, PivotPickingStrategy pivotPickingStrategy) 
        where T : IComparable<T>
    {
        IPartitionStrategy partition = partitionStrategy switch
        {
            PartitionStrategy.Naive => new NaivePartition(),
            PartitionStrategy.Lomuto => new LomutoPartition(),
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

        QuickSort(0, values.Count - 1);

        void QuickSort(int start, int end)
        {
            if (start < end)
            {
                var (pivotIndexStart, pivotIndexEnd) = partition.Partition(values, start, end, pivotPicking);
                QuickSort(start, pivotIndexStart - 1);
                QuickSort(pivotIndexEnd + 1, end);
            }
        }
    }


}
