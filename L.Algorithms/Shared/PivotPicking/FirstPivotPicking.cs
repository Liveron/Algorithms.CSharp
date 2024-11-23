namespace L.Algorithms.Shared.PivotPicking;

internal class FirstPivotPicking : IPivotPickingStrategy
{
    public T PickPivot<T>(IList<T> values, int start, int _) => values[start];
}
