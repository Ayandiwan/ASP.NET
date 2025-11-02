<Query Kind="Program" />

// LINQPad C# Script - LINQ Practice Examples

void Main()
{
    // 1️⃣ Simple numbers array - filter > 5
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    numbers.Where(n => n > 5).Dump("Numbers > 5");

    // 2️⃣ Sort numbers ascending
    numbers.OrderBy(n => n).Dump("Sorted Numbers");

    // 3️⃣ Strings starting with 'A'
    string[] names = { "Ayan", "Riya", "Sita", "Ankit", "Rahul" };
    names.Where(name => name.StartsWith("A")).Dump("Names starting with A");

    // 4️⃣ Objects: Students
    var students = new[]
    {
        new {Id=1, Name="Ayan", Marks=85, Grade="A"},
        new {Id=2, Name="Riya", Marks=92, Grade="A"},
        new {Id=3, Name="Sita", Marks=78, Grade="B"},
        new {Id=4, Name="Rahul", Marks=88, Grade="A"},
        new {Id=5, Name="Ankit", Marks=70, Grade="C"}
    };

    // Students with marks > 80
    students.Where(s => s.Marks > 80).Dump("Students with Marks > 80");

    // 5️⃣ Group students by Grade
    students.GroupBy(s => s.Grade)
            .Dump("Students Grouped by Grade");

    // 6️⃣ Select only names
    students.Select(s => s.Name).Dump("All Student Names");

    // 7️⃣ Order students by marks descending
    students.OrderByDescending(s => s.Marks)
            .Dump("Students ordered by Marks Descending");

    // 8️⃣ Count students per grade
    students.GroupBy(s => s.Grade)
            .Select(g => new { Grade = g.Key, Count = g.Count() })
            .Dump("Count of Students per Grade");

    // 9️⃣ First student with Marks > 80
    students.First(s => s.Marks > 80).Dump("First Student with Marks > 80");

    // 🔟 Any student with Marks < 75?
    bool anyLowMarks = students.Any(s => s.Marks < 75);
    anyLowMarks.Dump("Any Student with Marks < 75?");

    // 11️⃣ All students Marks > 60?
    bool allPassed = students.All(s => s.Marks > 60);
    allPassed.Dump("All Students passed?");

    // 12️⃣ Sum of marks
    students.Sum(s => s.Marks).Dump("Total Marks");

    // 13️⃣ Average marks
    students.Average(s => s.Marks).Dump("Average Marks");

    // 14️⃣ Max marks
    students.Max(s => s.Marks).Dump("Maximum Marks");

    // 15️⃣ Min marks
    students.Min(s => s.Marks).Dump("Minimum Marks");

    // 16️⃣ Skip & Take (pagination)
    students.Skip(2).Take(2).Dump("Skip 2 Take 2");

    // 17️⃣ Select anonymous with Name & Grade
    students.Select(s => new { s.Name, s.Grade }).Dump("Name & Grade Only");

    // 18️⃣ Concat two arrays
    int[] nums1 = { 1, 2, 3 };
    int[] nums2 = { 4, 5, 6 };
    nums1.Concat(nums2).Dump("Concatenated Arrays");

    // 19️⃣ Distinct example
    int[] nums3 = { 1, 2, 2, 3, 4, 4, 5 };
    nums3.Distinct().Dump("Distinct Numbers");

    // 20️⃣ Join two sequences (students + extra info)
    var grades = new[]
    {
        new {Grade="A", Description="Excellent"},
        new {Grade="B", Description="Good"},
        new {Grade="C", Description="Average"}
    };

    students.Join(grades,
                  s => s.Grade,
                  g => g.Grade,
                  (s, g) => new { s.Name, s.Marks, g.Description })
            .Dump("Students with Grade Description");
}
