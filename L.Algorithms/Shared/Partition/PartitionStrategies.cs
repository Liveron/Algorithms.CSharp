using L.Algorithms.Shared.PivotPicking;

namespace L.Algorithms.Shared.Partition;

public enum PartitionStrategy
{
    Naive,
    Lomuto,
    Hoare,
}

internal interface IPartitionStrategy
{
    public (int pivotIndexStart, int pivotIndexEnd) Partition<T>(
        IList<T> values, int start, int end, IPivotPickingStrategy pivotPicking) where T : IComparable<T>;
}
