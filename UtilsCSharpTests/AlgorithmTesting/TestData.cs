namespace UtilsCSharpTests.AlgorithmTesting;

public static class TestData
{
    public static object[] GetLoopLength { get; } =
    {
        // {expected, list}
        new object[] {3, new List<int> {1, 1, 2, 1, 1, 2}},
        new object[] {5, new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5}},
        new object[] {20, new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}},
        new object[] {3, new List<int> {25, 12, 13, 25, 12, 13}},
        new object[] {0,new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}},
        new object[] {0,new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 7, 1, 2, 3, 4, 5}},
        new object[] {5,new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5}},
        new object[] {5,new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4}},
        new object[] {0,new List<int> {0,1,2,3,4,5, 0,1,2,3,4,5, 0,1,2,3,4,6}},
        new object[] {5,new List<int> {0, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5}},
        new object[] {0,GetTooLongListInt()},
        new object[] {0,new List<int>{1,2}},
        new object[] {3, new List<long> {1L, 1L, 2L, 1L, 1L, 2L}},
        new object[] {5, new List<long> {1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L}},
        new object[] {20, new List<long> {1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L, 11L, 12L, 13L, 14L, 15L, 16L, 17L, 18L, 19L, 20L, 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L, 11L, 12L, 13L, 14L, 15L, 16L, 17L, 18L, 19L, 20L}},
        new object[] {3, new List<long> {25L, 12L, 13L, 25L, 12L, 13L}},
        new object[] {0,new List<long> {1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L, 11L, 12L, 13L, 14L, 15L, 16L, 17L, 18L, 19L, 20L}},
        new object[] {0,new List<long> {1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L, 7L, 1L, 2L, 3L, 4L, 5L}},
        new object[] {5,new List<long> {1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L}},
        new object[] {5,new List<long> {1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L}},
        new object[] {0,new List<long> {0L, 1L, 2L, 3L, 4L, 5L, 0L, 1L, 2L, 3L, 4L, 5L, 0L, 1L, 2L, 3L, 4L, 6L}},
        new object[] {5,new List<long> {0L, 1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L, 1L, 2L, 3L, 4L, 5L}},
        new object[] {0,GetTooLongListLong()},
        new object[] {0,new List<long>{1L,2L}},
    };

    private static List<long> GetTooLongListLong()
    {
        var list = new List<long>();
        for (var j = 0L; j < 2L; j++)
            for (var i = 0L; i < 201L; i++) 
                list.Add(i);
        
        return list;
    }

    private static List<int> GetTooLongListInt()
    {
        var list = new List<int>();
        for (var j = 0; j < 2; j++)
            for (var i = 0; i < 201; i++) 
                list.Add(i);
        
        return list;
    }

    public static object[] Sorting { get; } =
    {
        // expectedList, inputList
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
    
    
}