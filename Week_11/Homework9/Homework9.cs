namespace Homework9;

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

    }
}

public class Student
{
    public int studentID { get; private set; }
    public string? studentName { get; private set; }
    public static List<Student> studentList = new List<Student>();
    public static Dictionary<string, double> gradebook = new Dictionary<string, double>();

    public Student(int inputStudentID, string inputStudentName)
    {
        studentID = inputStudentID;
        studentName = inputStudentName;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static double CalculateAverageGPA()
    {
        return gradebook.Values.Average();
    }

    public static void PrintStudentsAboveAverageGPA(double grade)
    {
        foreach (Student student in studentList)
        {
            if (gradebook[student.studentName!] > grade)
            {
                student.PrintInfo();
            }
        }
    }

        public static bool CheckGradeBook(string name, double gpa)
    {
        bool checkIfAdded = false;
        if(!gradebook.ContainsKey(name))
        {
            gradebook.Add(name, gpa);
            checkIfAdded = !checkIfAdded;
        }
        return checkIfAdded;
    }


}
