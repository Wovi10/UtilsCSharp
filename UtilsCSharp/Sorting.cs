namespace UtilsCSharp;

public static class Sorting
{
    #region Exchange sorts

    /// <summary>
    /// Small collections (around 10 elements)
    /// Worst case time complexity: O(n^2)
    /// Best case time complexity: O(n) (Already sorted)
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> BubbleSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        bool swapped;
        do
        {
            swapped = false;
            for (var i = 0; i < list.Count - 1; i++)
            {
                var current = list[i];
                var next = list[i + 1];

                if (current.IsSmallerThanOrEqualTo(next))
                    continue;

                (list[i], list[i + 1]) = (next, current);
                swapped = true;
            }
        } while (swapped);

        return list;
    }

    /// <summary>
    /// Bidirectional bubble sort (Slightly improves bubble sort)
    /// Worst case time complexity: O(n^2)
    /// BEst case time complexity: O(n)
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> CocktailSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var isSwapped = true;
        var start = 0;
        var end = list.Count;

        while (isSwapped)
        {
            isSwapped = false;

            for (var i = start; i < end - 1; i++)
            {
                if (list[i].IsSmallerThan(list[i + 1]))
                    continue;

                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                isSwapped = true;
            }

            if (!isSwapped)
                break;

            isSwapped = false;
            end--;

            for (var i = end - 1; i >= start; i--)
            {
                if (list[i].IsSmallerThanOrEqualTo(list[i + 1]))
                    continue;

                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                isSwapped = true;
            }

            start++;
        }

        return list;
    }

    /// <summary>
    /// Bubble sort without compare overlap. (1st with 2nd, 3rd with 4th, etc. i.o. 1st with 2nd, 2nd with 3rd, etc.)
    /// Worst case time complexity: O(n^2)
    /// Best case time complexity: O(n)
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> BrickSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var isSorted = false;

        while (!isSorted)
        {
            isSorted = true;
            
            for (var i = 1; i <= list.Count - 2; i += 2) // Odd indeces
            {
                if (list[i].IsSmallerThanOrEqualTo(list[i + 1])) 
                    continue;

                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                isSorted = false;
            }
            
            for (var i = 0; i <= list.Count - 2; i += 2) // Even indeces
            {
                if (list[i].IsSmallerThanOrEqualTo(list[i + 1])) 
                    continue;

                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                isSorted = false;
            }
        }
        
        return list;
    }

    // Comb sort

    // Gnome sort

    // Proportion extend sort

    // Quick sort

    #endregion

    #region Selection sorts

    /// <summary>
    /// Small collections (around 10 elements)
    /// Worst case time complexity: O(n^2)
    /// Best case time complexity: O(n^2)
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> SelectionSort<T>(this List<T> list) where T : struct, IComparable<T>
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

    // Heap sort

    // Smooth sort

    // Cartesian tree sort

    // Tournament sort

    // Cycle sort

    // Weak heap sort

    #endregion

    #region Insertion sorts

    /// <summary>
    /// Small collections (around 10 elements)
    /// Worst case time complexity: O(n^2)
    /// Best case time complexity: O(n)
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> InsertionSort<T>(this List<T> list) where T : struct, IComparable<T>
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

    /// <summary>
    /// Medium-sized collections (around 100 elements)
    /// Worst case time complexity: O(n^2) (Insertion sort)
    /// Average case time complexity: O(n*log(n))
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> ShellSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var listLength = list.Count;

        var h = 1;
        while (h < list.Count / 3)
            h = 3 * h + 1;

        while (h >= 1)
        {
            for (var i = h; i < listLength; i++)
            {
                var temp = list[i];

                var j = i;
                while (j >= h && list[j - h].IsGreaterThanOrEqualTo(temp))
                {
                    list[j] = list[j - h];
                    j -= h;
                }

                list[j] = temp;
            }

            h = (h - 1) / 3;
        }

        return list;
    }

    // Splay sort

    // Tree sort

    // Library sort

    // Patience sort

    #endregion

    #region Merge sorts

    /// <summary>
    /// Medium to large collections (100-1000 elements)
    /// Average case time complexity: O(n*log(n))
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> MergeInto<T>(this List<T> a, List<T> b) where T : struct, IComparable<T>
    {
        var outputList = new List<T>();

        var indexA = 0;
        var indexB = 0;

        var arrayA = a.ToArray();
        var arrayB = b.ToArray();

        while (indexA < a.Count && indexB < b.Count)
        {
            var currentA = arrayA.ElementAt(indexA);
            var currentB = arrayB.ElementAt(indexB);

            outputList.Add(currentA.IsSmallerThan(currentB)
                ? arrayA.ElementAt(indexA++)
                : arrayB.ElementAt(indexB++));
        }

        while (indexA < a.Count)
            outputList.Add(arrayA.ElementAt(indexA++));

        while (indexB < b.Count)
            outputList.Add(arrayB.ElementAt(indexB++));

        return outputList;
    }

    // Cascade merge sort

    // Oscillating merge sort

    // Polyphase merge sort

    #endregion

    #region Distribution sorts

    // American flag sort

    // Bead sort

    // Bucket sort

    // Burst sort

    // Counting sort

    // Interpolation sort

    // Pigeonhole sort

    // Proxmap sort

    // Radix sort

    // Flash sort

    #endregion

    #region Concurrent sorts

    // Bitonic sort

    // Batcher odd-even merge sort

    // Pairwise sorting network

    // Sample sort

    #endregion

    #region Hybrid sorts

    // Block merge sort

    // Kirkpatrick-Reisch sort

    // Timsort

    // Intro sort

    // Spreadsort

    // Merge-insertion sort

    #endregion

    #region Other

    // Topological sort (Pre-topological order)

    // Pancake sort

    // Spaghetti sort

    #endregion

    #region Impractical

    // Stooge sort

    // Slow sort

    // Bogosort

    #endregion
}