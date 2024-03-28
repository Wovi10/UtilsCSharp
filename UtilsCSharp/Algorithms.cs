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
            var isCycle = true;
            for (var i = 0; i < n - cycleLength; i++)
            {
                if (list[i] == list[i + cycleLength]) 
                    continue;

                isCycle = false;
                break;
            }

            if (isCycle)
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
            var isCycle = true;
            for (var i = 0; i < n - cycleLength; i++)
            {
                if (list[i] == list[i + cycleLength]) 
                    continue;

                isCycle = false;
                break;
            }

            if (isCycle)
                return cycleLength;
        }

        return 0; // No cycle found
    }

    #endregion
}