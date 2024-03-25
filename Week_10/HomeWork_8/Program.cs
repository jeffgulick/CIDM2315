namespace HomeWork_8;

class Program
{
    static void Main(string[] args)
    {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
         // Test Q2.1
        PrintAllOddNumber(array_2d);

        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }
        

    // Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array){
        int sum = 0;

        foreach(int item in int_array){
            sum += item;
        }
        Console.WriteLine($"The Sum of int_array is: {sum}");
    }
  
    //Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[ , ] array_2d){
        //put your answer below
        foreach (int item in array_2d)
        {
            if (item%2 >0){
                Console.Write(item + " ");
            }
        } 
    }

    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[ , ] array_2d){
        
        int sum =0;
         for(int row=0; row < 3; row++){
            for(int col =0;col <3; col++){
                sum += array_2d[row, col];
            }
         }
        // foreach (int item in array_2d)
        // {
        //     sum += item;
        // }
         return sum;
    }

     // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[ , ] DoubleArray(int[ , ] array_2d){
         //put your answer below
         int[,] new_array = new int[3,3];
         for(int row=0; row < 3; row++){
            for(int col=0; col< 3; col++){
                new_array[row, col] = array_2d[row, col] * 2;
            }
         }
         return new_array; 
    }  




}
