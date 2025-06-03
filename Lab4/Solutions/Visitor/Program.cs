/* 
 the program demonstrates the Visitor design pattern
 it is a simulation of remote university system with different users
 it shows short certain parameters for different system member and generate logs report
 thanks to visitor pattern we can add new types of users without changing the existing code
 */

// set of unique university members
var people = new HashSet<IUniversityMember>
{
    new Student("Andrew Smith", new List<int> { 5, 4, 3, 2, 1, 0 }),
    new Teacher("John Kowalski", 142, new List<string> { "Mathematics", "Physics", "Chemistry" }),
    new Administrator("Director", new List<string> { "Log no. 1" }),
    //creation of Administrator with delay to simulate different time report
    new Func<IUniversityMember>(() =>
    {
        Thread.Sleep(1000);
        return new Administrator("Vice Director", new List<string> { "Log no. 2" });
    })(),
    new Administrator("Default admin of the system")
};

// adding log entry for the default admin, which deosn't have any logs yet
var defaultAdmin = people.OfType<Administrator>().FirstOrDefault(a => a.Name == "Default admin");
defaultAdmin?.AddUser();


// creating visitor for report generation
var visitor = new ReportVisitor();

// visit each person and generate a report
foreach (var person in people)
{
    // the Accept method is used to accept the visitor, typical in Visitor pattern
    person.Accept(visitor);
    Console.WriteLine();
}

// system member interface
public interface IUniversityMember
{
    string Name { get; }
    void Accept(IMemberVisitor visitor);
}

// visitor interface realized by the visitor pattern
public interface IMemberVisitor
{
    void Visit(Student student);
    void Visit(Teacher teacher);
    void Visit(Administrator admin);
}

// student class
public class Student : IUniversityMember
{
    public string Name { get; }
    public List<int> Grades { get; }

    public Student(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }

    public void Accept(IMemberVisitor visitor) => visitor.Visit(this);
}

// teacher class
public class Teacher : IUniversityMember
{
    public string Name { get; }
    public int GradesIssued { get; }
    public List<string> Subjects { get; }

    public Teacher(string name, int gradesIssued, List<string> subjects)
    {
        Name = name;
        GradesIssued = gradesIssued;
        Subjects = subjects;
    }

    public void Accept(IMemberVisitor visitor) => visitor.Visit(this);
}


// administrator class
public class Administrator : IUniversityMember
{
    public string Name { get; }
    public List<string> Logs { get; }
    public DateTime Date { get; }

    public Administrator(string name)
    {
        Name = name;
        Logs = new List<string>();
    }

    public Administrator(string name, List<string> logs)
    {
        Name = name;
        Logs = logs;
        Logs.Add((Date = DateTime.Now).ToString());
    }

    public void AddUser()
    {
        Logs.Add("User added");
    }

    public void Accept(IMemberVisitor visitor) => visitor.Visit(this);
}

// impelemntation of IMemberVisitor to generate reports depending on the type of person
public class ReportVisitor : IMemberVisitor
{
    public void Visit(Student student)
    {
        if (student.Grades.Count > 0)
        {
            double avg = student.Grades.Average();
            Console.WriteLine($"Student {student.Name} \nAverage grade: {avg:F2}");
        }
        else
        {
            Console.WriteLine($"Student: {student.Name} \nNo grades.");
        }
    }

    public void Visit(Teacher teacher)
    {
        Console.WriteLine($"Teacher: {teacher.Name} \nGrades issued: {teacher.GradesIssued}, Subjects taught: {teacher.Subjects.Count}");
        Console.WriteLine($"Subjects: {string.Join(", ", teacher.Subjects)}");
    }

    public void Visit(Administrator admin)
    {
        Console.WriteLine($"Administrator: {admin.Name} – System logs:");
        if (admin.Logs.Count > 0)
        {
            foreach (var log in admin.Logs)
            {
                Console.WriteLine($"{log}");
            }
        }
        else
        {
            Console.WriteLine("No system logs.");
        }
    }
}