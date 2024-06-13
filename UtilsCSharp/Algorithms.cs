﻿using System.Numerics;

namespace UtilsCSharp;

public static class Algorithms<T> where T: struct, INumber<T>, IComparable<T>
{
    #region Floyd's Tortoise and Hare (Cycle Detection)

    /// <summary>
    /// Floyd's Tortoise and Hare, cycle detection algorithm.
    /// Limited to a loop of 200 elements. This to prevent slow performance.
    /// </summary>
    /// <param name="list">A list in which to find a repeating pattern.</param>
    /// <typeparam name="T">The type used in the list.</typeparam>
    /// <returns>The length of the loop. 0 if no loop was found. Loop has to be repeated at least 3 times.</returns>
    public static T GetLoopLength(List<T> list)
    {
        var listCount = list.Count;
        const int minimumLoopLength = 3;
        if (listCount <= minimumLoopLength)
            return T.Zero;

        const int maximumLoopLength = 200;

        for (var loopLength = minimumLoopLength; loopLength <= listCount/2 && loopLength <= maximumLoopLength; loopLength++)
        {
            var hasCycle = false;
            for (var i = listCount - 1; i >= loopLength; i--)
            {
                // Check if the last cycleLength elements are the same as the cycleLength elements before that
                var endOfListRange = list[(listCount - loopLength)..listCount];
                var endOfListMinusCycleLengthRange = list[(listCount - loopLength * 2)..(listCount - loopLength)];

                if (!endOfListRange.SequenceEqual(endOfListMinusCycleLengthRange))
                    continue;

                hasCycle = true;
                break;
            }

            if (hasCycle)
                return T.CreateChecked(loopLength);
        }

        return T.Zero; // No cycle found
    }

    public static List<T> BubbleSort(List<T> list)
    {
        for (var i = 0; i < list.Count; i++)
        {
            var currentItem = list[i];
            for (var j = i + 1; j < list.Count; j++)
            {
                if (currentItem.IsGreaterThan(list[j]))
                    (list[j], currentItem) = (currentItem, list[j]);
            }
        }
        
        return list;
    }
    
    #endregion
}