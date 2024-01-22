namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // writes hello world to the console
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Jeff\nGulick");
        Console.WriteLine("I love to code!");

        int Age = 42;
        Console.WriteLine(Age);

        int m = 10;
        int n = m+10;
        n = 100;
        Console.WriteLine("Value of n: "+n);

        int my_age = 29;
        string my_name = "Alice";
        string hisName = "Jeff";

         // Assign variable to variable:
        int a = 10;
        int b = a;
        Console.WriteLine("Value of b: " +b);


        // Example:
        int x = 10;
        int y = x;
        x = 20;
        Console.WriteLine("Value of y: "+y);

        // string concatenation is the operation of joining strings end-to-end.
        Console.WriteLine("My name is " + my_name +", "+"I am "+my_age+ " years old");

        // string formatting
        Console.WriteLine("My name is {0}, I am {1} years old.", my_name, my_age);

        // string interpolation
        Console.WriteLine($"My name is {my_name}, I am {my_age} years old.");
        Console.WriteLine($"My name is {hisName}, I am {my_age + 13} years old.");

        int LabCapacity = 50;
        Console.WriteLine(LabCapacity);
        // change constant value will cause an error
        LabCapacity = 30; // error

        // string major = "CIS";

        // double weight = 150.5555;

        // float height = 5.5f;

        int a1 = 10;
        int b1 = 3;
        double c1 = 2.4;

       // Calculate: a/b, a/c, a*b, a*c, a-c and check the data type of these results.
        Console.WriteLine($"a = {a1}, b = {b1}, c = {c1}");
        Console.WriteLine($"a/b= {a1/b1}, Data type:{(a1/b1).GetType().Name}");
        Console.WriteLine($"a/c= {a1/c1}, Data Type: {(a1/c1).GetType().Name}");


    }
}
