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

}