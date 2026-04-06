namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        // Create students
        Student[] students = new Student[4];

        students[0] = new Student(111, "Alice");
        students[1] = new Student(222, "Bob");
        students[2] = new Student(333, "Cathy");
        students[3] = new Student(444, "David");

        Console.WriteLine("Total students: " + students.Length);

        // Create gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        // Check and add Tom
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        // Calculate average GPA
        double total = 0;
        foreach (var gpa in gradebook.Values)
        {
            total += gpa;
        }
        double avg = total / gradebook.Count;
        Console.WriteLine($"The average GPA is: {avg:F2}");

        string[] studentNames = new string[students.Length];
        for (int i = 0; i < students.Length; i++)
        {
            studentNames[i] = students[i].GetName();
        }
        foreach (var student in students)
        {
            string name = student.GetName();
            int index = Array.IndexOf(studentNames, name);
            if (index != -1 && gradebook.ContainsKey(name) && gradebook[name] > avg)
            {
                student.PrintInfo();
            }
        }
    }
}
class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();
    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }
    public int GetID()
    {
        return studentID;
    }
    public string GetName()
    {
        return studentName;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}