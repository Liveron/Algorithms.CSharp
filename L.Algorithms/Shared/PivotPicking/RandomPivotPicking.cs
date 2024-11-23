using System.Security.Cryptography;

namespace L.Algorithms.Shared.PivotPicking;

internal class RandomPivotPicking : IPivotPickingStrategy
{
    public T PickPivot<T>(IList<T> values, int start, int end)
    {
        int index = RandomNumberGenerator.GetInt32(start, end + 1);
        return values[index];
    }
}