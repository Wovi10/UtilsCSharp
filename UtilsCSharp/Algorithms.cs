namespace UtilsCSharp;

public class Algorithms
{
    #region Floyd's Tortoise and Hare (Cycle Detection)

    /// <summary>
    /// Floyd's Tortoise and Hare, cycle detection algorithm.
    /// </summary>
    /// <param name="list">A list in which to find a repeating pattern.</param>
    /// <returns>The length of the loop. 0 if no loop was found.</returns>
    public static int GetLoopLength(List<int> list)
    {
        var n = list.Count;

        for (var cycleLength = 1; cycleLength <= n / 2; cycleLength++)
        {
            var hasCycle = false;
            for (var i = n - 1; i >= cycleLength; i--)
            {
                // Check if the last cycleLength elements are the same as the cycleLength elements before that
                var endOfListRange = list[(n - cycleLength)..n];
                var endOfListMinusCycleLengthRange = list[(n - cycleLength * 2)..(n - cycleLength)];

                if (!endOfListRange.SequenceEqual(endOfListMinusCycleLengthRange)) 
                    continue;

                hasCycle = true;
                break;
            }

            if (hasCycle)
                return cycleLength;
        }

        return 0; // No cycle found
    }

    /// <summary>
    /// Floyd's Tortoise and Hare, cycle detection algorithm.
    /// </summary>
    /// <param name="list">A list in which to find a repeating pattern.</param>
    /// <returns>The length of the loop. 0 if no loop was found.</returns>
    public static int GetLoopLength(List<long> list)
    {
        var n = list.Count;

        for (var cycleLength = 1; cycleLength <= n / 2; cycleLength++)
        {
            var hasCycle = false;
            for (var i = n - 1; i >= cycleLength; i--)
            {
                // Check if the last cycleLength elements are the same as the cycleLength elements before that
                var endOfListRange = list[(n - cycleLength)..n];
                var endOfListMinusCycleLengthRange = list[(n - cycleLength * 2)..(n - cycleLength)];

                if (!endOfListRange.SequenceEqual(endOfListMinusCycleLengthRange)) 
                    continue;

                hasCycle = true;
                break;
            }

            if (hasCycle)
                return cycleLength;
        }

        return 0; // No cycle found
    }

    #endregion
}