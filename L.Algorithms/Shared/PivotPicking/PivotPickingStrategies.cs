namespace L.Algorithms.Shared.PivotPicking;

public enum PivotPickingStrategy
{
    First,
    Last,
    Random,
    Median,
}

internal interface IPivotPickingStrategy
{
    public T PickPivot<T>(IList<T> values, int start, int end);
}
