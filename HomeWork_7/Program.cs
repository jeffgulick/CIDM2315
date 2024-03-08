using System.Reflection.Metadata;

namespace HomeWork_7;

class Program
{
    static void Main(string[] args)
    {
        Customer _cus2 = new Customer(111, "Bob", 30);
        Customer _cus1 = new Customer(110, "Alice", 28);

        _cus1.PrintCusInfo();
        _cus2.PrintCusInfo();

        _cus1.ChangeID(220);
        _cus2.ChangeID(221);
        _cus1.PrintCusInfo();
        _cus2.PrintCusInfo();

        _cus1.CompareAge(_cus2);


    }
}
