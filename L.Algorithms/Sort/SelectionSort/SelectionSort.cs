namespace L.Algorithms;

public static partial class Sort<T> where T : IComparable<T>
{
    public static IList<T> SelectionSort(IList<T> values)
    {
        for (int i = 0; i < values.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i; j < values.Count; j++)
            {   
                    if (values[j].CompareTo(values[minIndex]) < 0)
                        minIndex = j;
            }
            if (minIndex != i)
                (values[i], values[minIndex]) = (values[minIndex], values[i]);
        }

        return values;
    }
}
