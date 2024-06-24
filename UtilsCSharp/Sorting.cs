﻿using System.Numerics;
using UtilsCSharp.Utils;

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

    /// <summary>
    /// Comb sort (Improves bubble sort) (Shrink factor: 1.3)
    /// Worst case time complexity: O(n^2)
    /// Best case time complexity: O(n*log(n))
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> CombSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var length = list.Count;
        var gap = length;
        var hasSwapped = true;

        while (gap != 1 || hasSwapped)
        {
            gap = GetNextGap(gap);
            hasSwapped = false;

            for (var i = 0; i < length - gap; i++)
            {
                if (list[i].IsSmallerThanOrEqualTo(list[i + gap]))
                    continue;

                (list[i], list[i + gap]) = (list[i + gap], list[i]);
                hasSwapped = true;
            }
        }

        return list;

        int GetNextGap(int currentGap)
        {
            currentGap = (int)(currentGap / 1.3);
            return currentGap < 1 ? 1 : currentGap;
        }
    }

    /// <summary>
    /// Goes left if the current element is smaller than the previous element, otherwise goes right.
    /// Worst case time complexity: O(n^2)
    /// Average case time complexity: O(n^2)
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> GnomeSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var index = 0;
        while (index < list.Count)
        {
            if (index == 0)
                index++;

            if (list[index].IsGreaterThanOrEqualTo(list[index - 1]))
                index++;
            else
            {
                (list[index], list[index - 1]) = (list[index - 1], list[index]);
                index--;
            }
        }

        return list;
    }

    // Proportion extend sort (Not practical for the average list)

    /// <summary>
    /// Choose pivot and partition the list into two sublists. Put everything smaller than the pivot to the left and everything greater to the right.
    /// Repeat.
    /// Worst case time complexity: O(n^2)
    /// Average case time complexity: O(n*log(n))
    /// </summary>
    /// <param name="list"></param>
    /// <param name="low">Lowest index</param>
    /// <param name="high">Highest index</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> QuickSort<T>(this List<T> list, int? low = null, int? high = null)
        where T : struct, IComparable<T>, INumber<T>
    {
        low ??= 0;
        high ??= list.Count - 1;

        if (low >= high)
            return list;

        var pi = list.Partition((int)low, (int)high);

        QuickSort(list, low, pi - 1);
        QuickSort(list, pi + 1, high);

        return list;
    }

    private static int Partition<T>(this List<T> list, int low, int high) where T : struct, IComparable<T>
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

    /// <summary>
    /// More advanced version of selection sort. Finds both the minimum and maximum and puts them in the correct position.
    /// Worst case time complexity: O(n*log(n))
    /// Average case time complexity: O(n*log(n))
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> HeapSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var length = list.Count;

        for (var i = length / 2 - 1; i >= 0; i--)
            Heapify(list, length, i);

        for (var i = length - 1; i > 0; i--)
        {
            (list[0], list[i]) = (list[i], list[0]);
            Heapify(list, i, 0);
        }

        return list;
    }

    private static void Heapify<T>(List<T> list, int length, int index) where T : struct, IComparable<T>
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

    /// <summary>
    /// Better than heapSort when the list is partly sorted.
    /// Worst case time complexity: O(n*log(n))
    /// Average case time complexity: O(n*log(n))
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> SmoothSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var length = list.Count;
        var p = length - 1;
        var q = p;
        var r = 0;

        while (p > 0)
        {
            if ((r & 0x03) == 0) 
                HeapifySmooth(list, r, q);

            if (Leonardo(r) == p)
                r++;
            else
            {
                r--;
                q -= Leonardo(r);
                HeapifySmooth(list, r, q);
                q = r - 1;
                r++;
            }

            (list[0], list[p]) = (list[p], list[0]);
            p--;
        }

        for (var i = 0; i < length - 1; i++)
        {
            var j = i + 1;
            while (j > 0 && list[j].IsSmallerThan(list[j - 1]))
            {
                (list[j], list[j - 1]) = (list[j - 1], list[j]);
                j--;
            }
        }

        return list;
    }

    private static void HeapifySmooth<T>(this List<T> list, int start, int end) where T : struct, IComparable<T>
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

    private static int Leonardo(int index)
    {
        if (index < 2)
            return 1;

        return Leonardo(index - 1) + Leonardo(index - 2) + 1;
    }

    /// <summary>
    /// Creates a tree structure starting from the smallest item, then takes the smallest to the left and right of the root.
    /// Worst case time complexity: O(n*log(n))
    /// Best case time complexity: O(n)
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static List<T> CartesianTreeSort<T>(this List<T> list) where T : struct, IComparable<T>,INumber<T>
    {
        var startIndex = list.Count;
        var rootNode = list.BuildCartesianTree(startIndex);

        return SortingUtils.PqBasedTraversal(rootNode);
    }

    

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