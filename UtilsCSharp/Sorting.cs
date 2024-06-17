namespace UtilsCSharp;

public static class Sorting
{
    public static List<T> BubbleSort<T>(List<T> list) where T : struct, IComparable<T>
    {
        bool swapped;
        do
        {
            swapped = false;
            for (var i = 0; i < list.Count - 1; i++)
            {
                var current = list[i];
                var next = list[i + 1];

                if (current.IsSmallerOrEqualTo(next))
                    continue;

                (list[i], list[i + 1]) = (next, current);
                swapped = true;
            }
        } while (swapped);

        return list;
    }

    public static List<T> SelectionSort<T>(List<T> list) where T : struct, IComparable<T>
    {
        for (var i = 0; i < list.Count; i++)
        {
            var minimum = i;
            for (var j = i + 1; j < list.Count; j++)
            {
                if (list[j].IsSmallerThan(list[minimum]))
                    minimum = j;
            }

            if (minimum == i)
                continue;

            (list[i], list[minimum]) = (list[minimum], list[i]);
        }

        return list;
    }

    public static List<T> InsertionSort<T>(List<T> list) where T : struct, IComparable<T>
    {
        for (var i = 1; i < list.Count; i++)
        {
            var current = list[i];
            var j = i - 1;
            while (j >= 0 && list[j].IsGreaterThan(current))
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = current;
        }

        return list;
    }
}