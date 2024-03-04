using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace HomeWork_6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        Professor p2 = new Professor();
        Student s1 = new Student();
        Student s2 = new Student();

        //Prof one
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        double p1Salary = p1.GetSalary();

        //Prof 2
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        double p2Salary = p2.GetSalary();

        //Student 1
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        // s1.studentGrade = 90;
        s1.SetGrade(90);
        double s1Grade = s1.GetGrade();

        //Student 2
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        // s1.studentGrade = 90;
        s2.SetGrade(80);
        double s2Grade = s2.GetGrade();

        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach}, and earns a salary of: {p1.GetSalary()}\nProfessor {p2.profName} teaches {p2.classTeach}, and earns a salary of: {p2.GetSalary()}");
        Console.WriteLine($"Student {s1.studentName} enrolls in {s1.classEnroll}, and the grade is: {s1.GetGrade()}\nStudent {s2.studentName} enrolls in {s2.classEnroll}, and the grade is: {s2.GetGrade()}");
        Console.WriteLine($"The Salary difference between {p1.profName} and {p2.profName} is: {GetDifference(p1Salary, p2Salary)}\nThe total grade of {s1.studentName} and {s2.studentName} is: {GetTotal(s1Grade, s2Grade)}");
    }

    static double GetDifference (double num1, double num2)
    {
      double difference =  num1 > num2 ? num1 - num2 : num2 - num1;
      return difference;
    }

    static double GetTotal (double n1, double n2)
    {
        return n1 + n2;
    }
}
