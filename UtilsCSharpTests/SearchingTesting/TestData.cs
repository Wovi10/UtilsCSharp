namespace UtilsCSharpTests.SearchingTesting;

public class TestData
{
    public static IEnumerable<TestCaseData> BinarySearchCases
    {
        get
        {
            yield return new TestCaseData(2, new[] {1, 2, 3, 4, 5}, 3);
            yield return new TestCaseData(-1, new[] {1, 2, 3, 4, 5}, 6);
            yield return new TestCaseData(-1, new[] {1, 2, 3, 4, 5}, 0);
        }
    }
}