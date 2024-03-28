namespace UtilsCSharp;

public class Algorithms
{
    #region Floyd's Tortoise and Hare (Cycle Detection)

    /// <summary>
    /// Floyd's Tortoise and Hare, cycle detection algorithm.
    /// Loop detection is limited to a loop of 200 elements. This to prevent slow performance.
    /// </summary>
    /// <param name="list">A list in which to find a repeating pattern.</param>
    /// <returns>The length of the loop. 0 if no loop was found. Loop has to be repeated at least 3 times.</returns>
    public static int GetLoopLength(List<int> list)
    {
        var n = list.Count;
        const int minimumLoopLength = 3;
        if (n <= minimumLoopLength)
            return 0;

        const int maximumLoopLength = 200;

        for (var loopLength = minimumLoopLength; loopLength <= n / 2 && loopLength <= maximumLoopLength; loopLength++)
        {
            var hasCycle = false;
            for (var i = n - 1; i >= loopLength; i--)
            {
                // Check if the last cycleLength elements are the same as the cycleLength elements before that
                var endOfListRange = list[(n - loopLength)..n];
                var endOfListMinusCycleLengthRange = list[(n - loopLength * 2)..(n - loopLength)];

                if (!endOfListRange.SequenceEqual(endOfListMinusCycleLengthRange))
                    continue;

                // Check if the cycle is repeated at least 3 times
                var endOfListMinusTwiceCycleLengthRange = list[(n - loopLength * 3)..(n - loopLength * 2)];
                if (!endOfListRange.SequenceEqual(endOfListMinusTwiceCycleLengthRange))
                    continue;

                hasCycle = true;
                break;
            }

            if (hasCycle)
                return loopLength;
        }

        return 0; // No cycle found
    }

    /// <summary>
    /// Floyd's Tortoise and Hare, cycle detection algorithm.
    /// Loop detection is limited to a loop of 200 elements. This to prevent slow performance.
    /// </summary>
    /// <param name="list">A list in which to find a repeating pattern.</param>
    /// <returns>The length of the loop. 0 if no loop was found. Loop has to be repeated at least 3 times.</returns>
    public static int GetLoopLength(List<long> list)
    {
        var n = list.Count;
        const int minimumLoopLength = 3;
        if (n <= minimumLoopLength)
            return 0;

        const int maximumLoopLength = 200;

        for (var cycleLength = minimumLoopLength;
             cycleLength <= n / 2 && cycleLength <= maximumLoopLength;
             cycleLength++)
        {
            var hasCycle = false;
            for (var i = n - 1; i >= cycleLength; i--)
            {
                // Check if the last cycleLength elements are the same as the cycleLength elements before that
                var endOfListRange = list[(n - cycleLength)..n];
                var endOfListMinusCycleLengthRange = list[(n - cycleLength * 2)..(n - cycleLength)];

                if (!endOfListRange.SequenceEqual(endOfListMinusCycleLengthRange))
                    continue;

                // Check if the cycle is repeated at least 3 times
                var endOfListMinusTwiceCycleLengthRange = list[(n - cycleLength * 3)..(n - cycleLength * 2)];
                if (!endOfListRange.SequenceEqual(endOfListMinusTwiceCycleLengthRange))
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