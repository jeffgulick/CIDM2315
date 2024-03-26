
namespace Array_Practice;

public class ArrayFun
{
    public int[]? int_arr { get; set; } 
    public int[,]? array_2d { get; set; }

    public static int ArraySum(int[] arr)
    {
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        return sum;
    }
   
    public void PrintAllOddNumbers (int[,] arr2)
    {
        foreach (int i in arr2)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }

    public int ElementSum(int[,] arr2)
    {
        int sum = 0;
        foreach (int i in arr2)
        {
            sum += i;
        }
        return sum;
    }

    public static int[ , ] DoubleArray(int[ , ] arr2){
         //put your answer below
         int[,] new_array = new int[3,3];
         for(int row=0; row < 3; row++){
            for(int col=0; col< 3; col++){
                new_array[row, col] = arr2[row, col] * 2;
            }
         }
         return new_array; 
    }  
}
