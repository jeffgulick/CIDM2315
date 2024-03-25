using System.Runtime.CompilerServices;

namespace HomeWork_8;

class Program
{
    static void Main(string[] args)
    {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

    }

    // Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array){
        int sum = 0;

        foreach(int item in int_array){
            sum += item;
        }
        Console.WriteLine($"The Sum of int_array is: {sum}");
    }
  







}
