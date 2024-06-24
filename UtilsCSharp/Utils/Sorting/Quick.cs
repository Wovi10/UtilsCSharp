namespace UtilsCSharp.Utils.Sorting;

internal  static class Quick
{
    public static int Partition<T>(this List<T> list, int low, int high) where T : struct, IComparable<T>
    {
        var pivot = list[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
        {
            if (!list[j].IsSmallerThan(pivot))
                continue;

            i++;
            (list[i], list[j]) = (list[j], list[i]);
        }

        (list[i + 1], list[high]) = (list[high], list[i + 1]);
        return i + 1;
    }
}