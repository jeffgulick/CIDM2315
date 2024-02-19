namespace HomeWork_5;

class Program
{
    static void Main(string[] args)
    {
        int input1, input2, input3, input4;

        //Prints the largest of two numbers
        Console.WriteLine("Enter the first number: ");
        input1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        input2 = Convert.ToInt16(Console.ReadLine());

        int largestNum1 = GetLargest(input1, input2);
        Console.WriteLine($"a = {input1}; b = {input2}");
        Console.WriteLine("The largest number is: " + largestNum1);

        //Prints the largest of 4 numbers//
        Console.WriteLine("Enter the first number: ");
        input1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        input2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        input3 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the fourth number: ");
        input4 = Convert.ToInt16(Console.ReadLine());

        int largestNum2 = LargestOfFour(input1, input2, input3, input4);
        Console.WriteLine($"a = {input1}; b = {input2}; c = {input3}; d = {input4}");
        Console.WriteLine($"The largest number is: {largestNum2}");
    }

    //returns largest of two numbers
    static int GetLargest(int input1, int input2)
    {
         
        if(input1 > input2){
            return input1;

    }
        else{
            return input2;
        }
    }

    //returns largest of four numbers
    static int LargestOfFour(int input1, int input2, int input3, int input4)
    {
        int max1, max2, max;

        max1 = GetLargest(input1, input2);
        max2 = GetLargest(input3, input4);
        max =  GetLargest(max1, max2);

        return max;
    }

}
