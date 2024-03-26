namespace Array_Practice;

class Program
{
    static void Main(string[] args)
    {
        ArrayFun arrayFun = new ArrayFun();

        int []? arr = arrayFun.int_arr = new int[] { 11, 23, 31, 42, 53 };
        int[,] arr_2d = arrayFun.array_2d = new int[,] 
        { 
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9} 
        };

        int int_arrSum  = ArrayFun.ArraySum(arr);
        Console.WriteLine($"The Sum of int_array is: {int_arrSum}");
        arrayFun.PrintAllOddNumbers(arr_2d);
        int array_2dSum = arrayFun.ElementSum(arr_2d);
        Console.WriteLine($"\nSum of 2d array: {array_2dSum}");

        int[,] doubledArray = ArrayFun.DoubleArray(arr_2d);
        Console.WriteLine("The new 2d array:");
        foreach (int i in doubledArray)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
}
}
