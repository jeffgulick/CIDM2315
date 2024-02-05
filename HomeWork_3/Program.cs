namespace HomeWork_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HomeWork 3");
        Console.WriteLine("Question 1: Check if N is prime or not");

        // Question 1
        Console.WriteLine("Intput an integer:");
        int N = Convert.ToInt16(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i < N; i++) {

            if (N % i == 0) {
                isPrime = false;
                break;
            }

        }

        if (isPrime) {
            Console.WriteLine("N is prime");
        } else {
            Console.WriteLine("N is non-prime");
        }

        // Question 2
        Console.WriteLine("Question 2: Print a square of N*N");
        Console.WriteLine("Assign an int value to N:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i <= num2; i++) {
            for (int j = 1; j <= num2-1; j++) {
                Console.Write("#");
            }
            Console.WriteLine("#");
        }

        // Question 3
        Console.WriteLine("Question 3: Print a right triangle of N*N");
        Console.WriteLine("Assign an int value to N:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i <= num3; i++) {
            for (int j = 1; j <= i; j++) {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
