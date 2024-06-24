namespace UtilsCSharp.Utils.Sorting;

internal  static class Heap
{
    public static void Heapify<T>(this List<T> list, int length, int index) where T : struct, IComparable<T>
    {
        while (true)
        {
            var largest = index;
            var left = 2 * index + 1;
            var right = 2 * index + 2;

            if (left < length && list[left].IsGreaterThan(list[largest])) largest = left;

            if (right < length && list[right].IsGreaterThan(list[largest])) largest = right;

            if (largest == index)
                break;

            (list[index], list[largest]) = (list[largest], list[index]);
            index = largest;
        }
    }
}