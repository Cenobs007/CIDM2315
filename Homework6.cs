namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        // Create professors information
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.classTeach = "Teaching Java";
        prof1.SetSalary(9000);

        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.classTeach = "Teaching Math";
        prof2.SetSalary(8000);

        // Create students information
        Student stu1 = new Student();
        stu1.studentName = "Lisa";
        stu1.classEnroll = "Java";
        stu1.SetGrade(90);

        Student stu2 = new Student();
        stu2.studentName = "Tom";
        stu2.classEnroll = "Math";
        stu2.SetGrade(80);

        // Print Professor details
        Console.WriteLine("Professor 1:");
        Console.WriteLine("Name: " + prof1.profName);
        Console.WriteLine("Class: " + prof1.classTeach);
        Console.WriteLine("Salary: " + prof1.GetSalary());
        Console.WriteLine();

        Console.WriteLine("Professor 2:");
        Console.WriteLine("Name: " + prof2.profName);
        Console.WriteLine("Class: " + prof2.classTeach);
        Console.WriteLine("Salary: " + prof2.GetSalary());
        Console.WriteLine();

        // Print Student details
        Console.WriteLine("Student 1:");
        Console.WriteLine("Name: " + stu1.studentName);
        Console.WriteLine("Class Enrolled: " + stu1.classEnroll);
        Console.WriteLine("Grade: " + stu1.GetGrade());
        Console.WriteLine();

        Console.WriteLine("Student 2:");
        Console.WriteLine("Name: " + stu2.studentName);
        Console.WriteLine("Class Enrolled: " + stu2.classEnroll);
        Console.WriteLine("Grade: " + stu2.GetGrade());
        Console.WriteLine();

        // Difference in salaries
        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine("Salary Difference: " + salaryDifference);

        // Total grade
        double totalGrade = stu1.GetGrade() + stu2.GetGrade();
        Console.WriteLine("Total Grade: " + totalGrade);
    }
}
class Professor
{
    public string profName = "";
    public string classTeach = "";
    private double salary;
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }
}
class Student
{
    public string studentName = "";
    public string classEnroll = "";
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