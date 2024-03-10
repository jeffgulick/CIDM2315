namespace HomeWork_7;

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

        //using properties
        // _cus1.Cus_Id = 220;
        // _cus2.Cus_Id = 221;

        _cus1.PrintCusInfo();
        _cus2.PrintCusInfo();

        //calling _cus1 "CompareAge" method and passing _cus2 obj as parameter
        _cus1.CompareAge(_cus2); 
    }
}
