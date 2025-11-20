using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public partial class linqtoobjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ayan", City = "Anand", Marks = 85 },
                new Student { Id = 2, Name = "Hk", City = "Vadodara", Marks = 78 },
                new Student { Id = 3, Name = "Riya", City = "Surat", Marks = 92 },
                new Student { Id = 4, Name = "Karan", City = "Ahmedabad", Marks = 68 },
                new Student { Id = 5, Name = "Meera", City = "Vadodara", Marks = 74 }
            };

            string output = "";

            // 2. LINQ Query: Filter students from Vadodara
            var vadodaraStudents = from s in students
                                   where s.City == "Vadodara"
                                   select s;

            output += "<b>Students from Vadodara:</b><br/>";
            foreach (var student in vadodaraStudents)
            {
                output += $"Id: {student.Id}, Name: {student.Name}, City: {student.City}, Marks: {student.Marks}<br/>";
            }

            // 3. LINQ Query: Order students by Marks descending
            var topStudents = from s in students
                              orderby s.Marks descending
                              select s;

            output += "<br/><b>Students ordered by Marks (Highest to Lowest):</b><br/>";
            foreach (var student in topStudents)
            {
                output += $"Id: {student.Id}, Name: {student.Name}, Marks: {student.Marks}<br/>";
            }

            // 4. LINQ Method Syntax: Select only Names
            var studentNames = students.Select(s => s.Name).ToList();
            output += "<br/><b>List of Student Names:</b><br/>";
            foreach (var name in studentNames)
            {
                output += name + "<br/>";
            }

            // 5. LINQ Aggregation: Count, Average, Max, Min
            int totalStudents = students.Count();
            double averageMarks = students.Average(s => s.Marks);
            int maxMarks = students.Max(s => s.Marks);
            int minMarks = students.Min(s => s.Marks);

            output += $"<br/><b>Total Students:</b> {totalStudents}<br/>";
            output += $"<b>Average Marks:</b> {averageMarks}<br/>";
            output += $"<b>Maximum Marks:</b> {maxMarks}<br/>";
            output += $"<b>Minimum Marks:</b> {minMarks}<br/>";

            // 6. LINQ Query: Students who scored more than 75
            var highScorers = students.Where(s => s.Marks > 75);
            output += "<br/><b>Students with Marks > 75:</b><br/>";
            foreach (var student in highScorers)
            {
                output += $"Id: {student.Id}, Name: {student.Name}, Marks: {student.Marks}<br/>";
            }

            // Show output in Label
            lblOutput.Text = output;
        }
    }

    // Student class
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Marks { get; set; }
    }
}
