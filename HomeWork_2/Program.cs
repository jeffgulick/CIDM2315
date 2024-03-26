namespace HomeWork_2;
class Program
{
    static void Main(string[] args)
    {
        /*
        Q1.
        Input a grade in letters (A, B, C, D, F), print the corresponding GPA points
        A:4     B:3   C:2	D:1	F:0
        If the user input a letter rather than (A, B, C, D, F), then print “Wrong Letter Grade!”
        */


        string s = "SoloLearn";

        int x = s.Length;

        int y = s.IndexOf("e");

        Console.WriteLine(x%y);
        int[ , , ] array = new int[4, 5, 3];

        Console.WriteLine("Please input a letter grade: (A, B, C, D, F)");
        string grade = Console.ReadLine()!.ToUpper();

        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA point: 4.0");
                break;

            case "B":
                Console.WriteLine("GPA point: 3.0");
                break;

            case "C":
                Console.WriteLine("GPA point: 2.0");
                break;

            case "D":
                Console.WriteLine("GPA point: 1.0");
                break;

            case "F":
                Console.WriteLine("GPA point: 0.0");
                break;
            
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }


        /*  Q2.
        Ask the user to input three numbers and print the smallest value.
        */
        
        Console.WriteLine("Please input the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest = num1;

        if (num2 < smallest){
            smallest = num2;
        }
        if (num3 < smallest){
            smallest = num3;
        }
        // Better solution using Min method found in dontnet docs :
        // int[] numbers = {num1, num2, num3};
        // int smallest = numbers.Min();
        
        Console.WriteLine("The smallest number is: " + smallest);

        /* Bonus: Write a C# program that takes as input a year and check if it is a leap year. */

        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt16(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0){
            Console.WriteLine($"{year} is a leap year!");

        }
        else if (year % 100 == 0 && year % 400 == 0){
            Console.WriteLine($"{year} is a leap year!");
        }
        else{
            Console.WriteLine($"{year} is not a leap year!");
        }
    }
}
