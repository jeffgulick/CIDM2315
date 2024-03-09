class Student 
{
    public string studentName = string.Empty;
    public string classEnroll = string.Empty;
    // public double studentGrade {set; get;}
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}