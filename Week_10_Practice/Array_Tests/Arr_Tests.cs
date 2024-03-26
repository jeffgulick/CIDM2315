using Array_Practice;

namespace Array_Tests;

public class Arr_Tests
{
    [Fact]
    public void Test1()
    {
        ArrayFun arrayFun = new ArrayFun();

        int[]? arr = arrayFun.int_arr = new int[] { 11, 23, 31, 42, 53 };
        int[,] arr_2d = arrayFun.array_2d = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int int_arrSum = ArrayFun.ArraySum(arr);
        Assert.Equal(160, int_arrSum);
        arrayFun.PrintAllOddNumbers(arr_2d);
        int array_2dSum = arrayFun.ElementSum(arr_2d);
        Assert.Equal(45, array_2dSum);

        int[,] doubledArray = ArrayFun.DoubleArray(arr_2d);
        Assert.Equal(2, doubledArray[0, 0]);
        Assert.Equal(4, doubledArray[0, 1]);
        Assert.Equal(6, doubledArray[0, 2]);
        Assert.Equal(8, doubledArray[1, 0]);
        Assert.Equal(10, doubledArray[1, 1]);
        Assert.Equal(12, doubledArray[1, 2]);
        Assert.Equal(14, doubledArray[2, 0]);
        Assert.Equal(16, doubledArray[2, 1]);
        Assert.Equal(18, doubledArray[2, 2]);
    }
}