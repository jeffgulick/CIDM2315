using System.Security.Cryptography.X509Certificates;

class Professor 
{
    public string profName { get; set; } = string.Empty;
    public string classTeach { get; set; } = string.Empty;
    private double salary;

    public void SetSalary (double salary_amount) 
    {
        salary = salary_amount;
    }

    public double GetSalary ()
    {
        return salary;
    }

    public double GetSalaryDifference (Professor profObject)
    {
      return salary > profObject.salary ? salary - profObject.salary : profObject.salary - salary;
    }

}