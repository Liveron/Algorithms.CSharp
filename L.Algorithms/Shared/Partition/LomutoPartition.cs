using L.Algorithms.Shared.PivotPicking;

namespace L.Algorithms.Shared.Partition;

internal class LomutoPartition : IPartitionStrategy
{
    public (int pivotIndexStart, int pivotIndexEnd) Partition<T>(
        IList<T> values, int start, int end, IPivotPickingStrategy pivotPicking)
        where T : IComparable<T>
    {
        T pivot = pivotPicking.PickPivot(values, start, end);

        int pivotIndexStart = start, pivotIndexEnd = start;

        for (int i = start; i <= end; i++)
        {
            if (values[i].CompareTo(pivot) < 0)
            {
                (values[pivotIndexStart], values[i]) =
                    (values[i], values[pivotIndexStart]);

                if (pivotIndexEnd != pivotIndexStart)
                    (values[pivotIndexEnd], values[i]) =
                        (values[i], values[pivotIndexEnd]);

                pivotIndexStart++;
                pivotIndexEnd++;
            }
            else if (values[i].CompareTo(pivot) == 0)
            {
                (values[pivotIndexEnd], values[i]) =
                    (values[i], values[pivotIndexEnd]);

                pivotIndexEnd++;
            }
        }

        return (pivotIndexStart, pivotIndexEnd - 1);    
    }
}
