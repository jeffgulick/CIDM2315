namespace HomeWork7;

class Program
{
    static void Main(string[] args)
    {
        Customer _cus1 = new Customer(110, "Alice", 28);
        Customer _cus2 = new Customer(111, "Bob", 30);

        _cus1.PrintCusInfo();
        _cus2.PrintCusInfo();

        //using fields and methods
        _cus1.ChangeID(220);
        _cus2.ChangeID(221);

        _cus1.PrintCusInfo();
        _cus2.PrintCusInfo();

        //calling _cus1 "CompareAge" method and passing _cus2 obj as parameter
        _cus1.CompareAge(_cus2); 
    }
}

class Customer
{
    private int cus_id;
    public string cus_name { get; init; }
    public int cus_age { get; init; }

    public Customer (int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }
    
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo ()
    {
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if(objCustomer.cus_age > cus_age){
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else if(objCustomer.cus_age < cus_age){
            Console.WriteLine($"{cus_name} is older.");
        }
        else{
            Console.WriteLine($"{objCustomer.cus_name} and {cus_name} are the same age.");
        }; 
    }
}