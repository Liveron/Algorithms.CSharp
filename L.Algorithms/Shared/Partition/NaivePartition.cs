using L.Algorithms.Shared.PivotPicking;

namespace L.Algorithms.Shared.Partition;

internal class NaivePartition : IPartitionStrategy
{
    public (int pivotIndexStart, int pivotIndexEnd) Partition<T>(
        IList<T> values, int start, int end, IPivotPickingStrategy pivotPicking) 
        where T : IComparable<T>
    {
        T pivot = pivotPicking.PickPivot(values, start, end);

        var sorted = new Queue<T>(end - start + 1);

        int pivotIndexStart = start;

        for (int i = start; i <= end; i++)
            if (values[i].CompareTo(pivot) < 0)
            {
                sorted.Enqueue(values[i]);
                pivotIndexStart++;
            }

        int pivotIndexEnd = pivotIndexStart;

        for (int i = start; i <= end; i++)
            if (values[i].CompareTo(pivot) == 0)
            {
                sorted.Enqueue(values[i]);
                pivotIndexEnd++;
            }

        for (int i = start; i <= end; i++)
            if (values[i].CompareTo(pivot) > 0)
                sorted.Enqueue(values[i]);

        for (int i = start; i <= end; i++)
            values[i] = sorted.Dequeue();

        return (pivotIndexStart, pivotIndexEnd - 1);
    }
}
