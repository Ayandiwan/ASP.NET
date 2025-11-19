<Query Kind="Program" />

void Main()
{
    // 1. Create a list of students
    var students = new List<Student>
    {
        new Student { Id = 1, Name = "Ayan", City = "Anand", Marks = 85 },
        new Student { Id = 2, Name = "Hk", City = "Vadodara", Marks = 78 },
        new Student { Id = 3, Name = "Riya", City = "Surat", Marks = 92 },
        new Student { Id = 4, Name = "Karan", City = "Ahmedabad", Marks = 68 },
        new Student { Id = 5, Name = "Meera", City = "Vadodara", Marks = 74 }
    };

    // 2. LINQ Query: Filter students from Vadodara
    var vadodaraStudents = from s in students
                           where s.City == "Vadodara"
                           select s;

    "Students from Vadodara:".Dump();
    vadodaraStudents.Dump();

    // 3. LINQ Query: Order students by Marks descending
    var topStudents = from s in students
                      orderby s.Marks descending
                      select s;

    "Students ordered by Marks (Highest to Lowest):".Dump();
    topStudents.Dump();

    // 4. LINQ Method Syntax: Select only Names
    var studentNames = students.Select(s => s.Name).ToList();
    "List of Student Names:".Dump();
    studentNames.Dump();

    // 5. LINQ Aggregation: Count, Average, Max, Min
    var totalStudents = students.Count();
    var averageMarks = students.Average(s => s.Marks);
    var maxMarks = students.Max(s => s.Marks);
    var minMarks = students.Min(s => s.Marks);

    $"Total Students: {totalStudents}".Dump();
    $"Average Marks: {averageMarks}".Dump();
    $"Maximum Marks: {maxMarks}".Dump();
    $"Minimum Marks: {minMarks}".Dump();

    // 6. LINQ Query: Students who scored more than 75
    var highScorers = students.Where(s => s.Marks > 75);
    "Students with Marks > 75:".Dump();
    highScorers.Dump();
}

// Student class
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int Marks { get; set; }
}
