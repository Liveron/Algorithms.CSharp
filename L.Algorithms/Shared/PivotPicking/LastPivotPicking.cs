namespace L.Algorithms.Shared.PivotPicking;

internal class LastPivotPicking : IPivotPickingStrategy
{
    public T PickPivot<T>(IList<T> values, int _, int end) => values[end];
}
