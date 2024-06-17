namespace UtilsCSharpTests.SortingTesting;

public class TestData
{
    public static object[] Sorting { get; } =
    {
        // {expectedList, inputList}
        new object[] {new List<int> {1, 2, 3, 4, 5}, new List<int> {5, 3, 1, 4, 2}},
        new object[] {new List<int> {1, 2, 3, 4, 5}, new List<int> {5, 4, 3, 2, 1}},
        new object[] {new List<int> {1, 2, 3, 4, 5}, new List<int> {1, 2, 3, 4, 5}},
        new object[] {new List<long> {1L, 2L, 3L, 4L, 5L}, new List<long> {5L, 3L, 1L, 4L, 2L}},
        new object[] {new List<long> {1L, 2L, 3L, 4L, 5L}, new List<long> {5L, 4L, 3L, 2L, 1L}},
        new object[] {new List<long> {1L, 2L, 3L, 4L, 5L}, new List<long> {1L, 2L, 3L, 4L, 5L}},
        new object[] {new List<double> {1D, 2D, 3D, 4D, 5D}, new List<double> {5D, 3D, 1D, 4D, 2D}},
        new object[] {new List<double> {1D, 2D, 3D, 4D, 5D}, new List<double> {5D, 4D, 3D, 2D, 1D}},
        new object[] {new List<double> {1D, 2D, 3D, 4D, 5D}, new List<double> {1D, 2D, 3D, 4D, 5D}}
    };

    public static object[] MergeCases { get; } =
    {
        // {expectedList, inputListA, inputListB}
        new object[] {new List<int> {1, 2, 3, 4, 5}, new List<int> {1, 2, 3}, new List<int> {4, 5}},
        new object[] {new List<int> {1, 2, 3, 4, 5}, new List<int> {1, 3, 5}, new List<int> {2, 4}}
    };
}