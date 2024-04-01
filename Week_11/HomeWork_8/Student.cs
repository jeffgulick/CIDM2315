namespace HomeWork_8;

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

}
