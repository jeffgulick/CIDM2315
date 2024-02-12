using System.Globalization;

namespace HomeWork_4;

class Program
{
    static void Main(string[] args)
    {
        LargestValue();

        Console.WriteLine("Please enter a number: ");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter left or right");
        string shape = Console.ReadLine().ToLower();
        Console.WriteLine();

        PrintShape(N, shape);
    }

    static void LargestValue()
    {
        Console.WriteLine("Please enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool isNum1Larger = num1 > num2;

        Console.WriteLine($"a = {num1}; b = {num2}");

        if (isNum1Larger)
        {
            Console.WriteLine($"The largest number is: {num1}");
        }
        else if (num1 == num2)
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            Console.WriteLine($"The largest number is: {num2}");
        }
    }

    static void PrintShape( int num, string shape)
    {
        Console.WriteLine($"N is: {num}; Shape is {shape}");

        if(shape == "left")
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if(shape == "right")
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid shape");
        }
    }
}
