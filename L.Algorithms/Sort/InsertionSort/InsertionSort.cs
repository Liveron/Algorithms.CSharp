namespace L.Algorithms;

public static partial class Sort<T> where T : IComparable<T>
{
    // O(n^2)
    public static IList<T> InsertionSort(IList<T> values)
    {
        for (int i = 1; i < values.Count; i++)
        {
            T key = values[i];
            int j = i - 1;
            while (j >= 0 && values[j].CompareTo(key) > 0)
            {
                values[j + 1] = values[j];
                j--;
            }
            values[j + 1] = key;
        }
        return values;
    }
}
