namespace HomeWork_8;

class Program
{
    static void Main(string[] args)
    {
        Student stu_1 = new Student(111, "Alice");
        Student stu_2 = new Student(222, "Bob");
        Student stu_3 = new Student(333, "Cathy");
        Student stu_4 = new Student(444, "David");

        Student.gradebook.Add(stu_1.studentName!, 4.0);
        Student.gradebook.Add(stu_2.studentName!, 3.6);
        Student.gradebook.Add(stu_3.studentName!, 2.5);
        Student.gradebook.Add(stu_4.studentName!, 1.8);

        if(Student.CheckGradeBook("Tom", 3.3))
        {
            Student stu_5 = new Student(555, "Tom");
        }


        double averageGrade = Student.CalculateAverageGPA();
        Console.WriteLine($"The average GPA is: {averageGrade}");

        Student.PrintStudentsAboveAverageGPA(averageGrade);

        foreach(KeyValuePair<string, double> stu in Student.gradebook)
        {
            Console.WriteLine($"{stu.Key}, {stu.Value}");
        }

    }
}