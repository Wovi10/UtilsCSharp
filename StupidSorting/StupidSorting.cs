using UtilsCSharp;

namespace StupidSorting;

public static class StupidSorting
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> GnomeSort<T>(this List<T> list) where T : struct, IComparable<T>
    {
        var index = 0;
        while(index < list.Count)
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
}