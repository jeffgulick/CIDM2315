class Student 
{
    public string studentName;
    public string classEnroll;
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