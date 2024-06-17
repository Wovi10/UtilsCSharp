namespace UtilsCSharp;

public static class Searching
{
    /// <summary>
    /// Binary search algorithm
    /// </summary>
    /// <param name="input"></param>
    /// <param name="searchKey"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The index at which you can find the item to be found. The length of the input if not found.</returns>
    public static int BinarySearch<T>(this IEnumerable<T> input, T searchKey) where T : struct, IComparable<T>
    {
        var inputArray = input as T[] ?? input.ToArray();

        var lowerBound = 0;
        var upperBound = inputArray.Length - 1;

        while (true)
        {
            var currentIndex = (lowerBound + upperBound) / 2;

            if (inputArray.ElementAt(currentIndex).Equals(searchKey))
                return currentIndex;

            if (lowerBound > upperBound)
                throw new KeyNotFoundException();

            if (inputArray.ElementAt(currentIndex).IsSmallerThan(searchKey))
                lowerBound = currentIndex + 1;
            else
                upperBound = currentIndex - 1;
        }
    }
}