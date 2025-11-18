<Query Kind="Program" />

void Main()
{
    // 1. Create XML using LINQ to XML
    XElement studentsXml = new XElement("Students",
        new XElement("Student",
            new XAttribute("Id", 1),
            new XElement("Name", "Ayan"),
            new XElement("City", "Anand"),
            new XElement("Marks", 85)
        ),
        new XElement("Student",
            new XAttribute("Id", 2),
            new XElement("Name", "Hk"),
            new XElement("City", "Vadodara"),
            new XElement("Marks", 78)
        ),
        new XElement("Student",
            new XAttribute("Id", 3),
            new XElement("Name", "Riya"),
            new XElement("City", "Surat"),
            new XElement("Marks", 92)
        ),
        new XElement("Student",
            new XAttribute("Id", 4),
            new XElement("Name", "Karan"),
            new XElement("City", "Ahmedabad"),
            new XElement("Marks", 68)
        )
    );

    // 2. Display the complete XML
    "Complete XML:".Dump();
    studentsXml.Dump();

    // 3. LINQ to XML Query: Select students from Vadodara
    var vadodaraStudents = from s in studentsXml.Elements("Student")
                           where (string)s.Element("City") == "Vadodara"
                           select s;

    "Students from Vadodara:".Dump();
    vadodaraStudents.Dump();

    // 4. Students with Marks > 75
    var highScorers = from s in studentsXml.Elements("Student")
                      where (int)s.Element("Marks") > 75
                      select s;

    "Students with Marks > 75:".Dump();
    highScorers.Dump();

    // 5. Students ordered by Name
    var orderedStudents = from s in studentsXml.Elements("Student")
                          orderby (string)s.Element("Name")
                          select s;

    "Students ordered by Name:".Dump();
    orderedStudents.Dump();
}
