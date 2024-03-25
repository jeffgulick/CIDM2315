using Xunit;
using HomeWork_8;

public class ProgramTests
{
    [Fact]
    public void TestArraySum()
    {
        int[] testArray = {11, 23, 31, 42, 53};
        int expectedSum = 160;
        Assert.Equal(expectedSum, Program.ArraySum(testArray));
    }

    [Fact]
    public void TestElementSum()
    {
        int[,] testArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int expectedSum = 45;
        Assert.Equal(expectedSum, Program.ElementSum(testArray));
    }

    [Fact]
    public void TestDoubleArray()
    {
        int[,] testArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int[,] expectedArray = {
            {2, 4, 6},
            {8, 10, 12},
            {14, 16, 18}
        };
        Assert.Equal(expectedArray, Program.DoubleArray(testArray));
    }
}