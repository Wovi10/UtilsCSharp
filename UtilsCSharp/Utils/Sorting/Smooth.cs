namespace UtilsCSharp.Utils.Sorting;

internal  static class Smooth
{
    public static void HeapifySmooth<T>(this List<T> list, int start, int end) where T : struct, IComparable<T>
    {
        var i = start;
        var j = 0;
        var k = 0;

        while (k < end - start + 1)
        {
            if ((k & 0xAAAAAAAA) == 0xAAAAAAAA)
            {
                j += i;
                i >>= 1;
            }
            else
            {
                i += j;
                j >>= 1;
            }

            k++;
        }

        while (i > 0)
        {
            j >>= 1;
            var l = i + j;
            while (l < end)
            {
                if (list[l].IsGreaterThan(list[l - i]))
                    break;

                (list[l], list[l - i]) = (list[l - i], list[l]);
                l += i;
            }

            i = j;
        }
    }

    public static int Leonardo(int index)
    {
        if (index < 2)
            return 1;

        return Leonardo(index - 1) + Leonardo(index - 2) + 1;
    }
}