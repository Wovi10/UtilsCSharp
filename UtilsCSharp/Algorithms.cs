namespace UtilsCSharp;

public class Algorithms
{
    #region Floyd's Tortoise and Hare (Cycle Detection)

    public static int GetCycleLength(List<int> list)
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
            {
                return cycleLength;
            }
        }

        return 0; // No cycle found
    }

    #endregion
}