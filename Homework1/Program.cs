namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        double X = 2.5;
        double Y = 3.3;
        double Z;

        //found this online. Returns a specified number raised to the specified power. I like it better
        Z = 4 * Math.Pow(X, 2) + 3 * Y;
        // z = 4 * x * x + 3 * y;

        Console.WriteLine($"X = {X}, Y = {Y}\nThe value of Z is: {Z}");


    }
}
