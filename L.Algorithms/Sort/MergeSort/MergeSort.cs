namespace L.Algorithms;

public static partial class Sort<T> where T : IComparable<T>
{
    // O(n*log(n))
    public static IList<T> MergeSort(IList<T> values)
    {
        if (values.Count <= 1) return values;
        int mid = values.Count / 2;
        IList<T> left = MergeSort([.. values.Take(mid)]);
        IList<T> right = MergeSort([.. values.TakeLast(values.Count - mid)]);
        return Merge(left, right);
    }

    private static T[] Merge(IList<T> left, IList<T> right)
    {
        var result = new T[left.Count + right.Count];
        int i = 0, j = 0, k = 0;

        while (i < left.Count && j < right.Count)
            result[k++] = left[i].CompareTo(right[j]) < 0 ? left[i++] : right[j++];

        while (i < left.Count)
            result[k++] = left[i++];

        while (j < right.Count)
            result[k++] = right[j++];

        return result;
    }
}
