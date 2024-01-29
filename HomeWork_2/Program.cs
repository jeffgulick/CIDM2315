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

        Console.WriteLine("Please input a letter grade: (A, B, C, D, F)");
        string grade = Console.ReadLine().ToUpper();

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
        
    }
}
