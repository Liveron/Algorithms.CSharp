namespace L.Algorithms;

public static partial class Search
{
    public static int BinarySearch<T>(IList<T> values, T element) 
        where T : IComparable<T>
    {
        int min = 0, max = values.Count - 1;
        while (min <= max)
        {
            int mid = (min + max) / 2;
            int compareResult = element.CompareTo(values[mid]);

            if (compareResult == 0)
                return mid;
            if (compareResult > 0)
                min = mid + 1;
            else 
                max = mid - 1;
        }

        return -1;
    }
}
