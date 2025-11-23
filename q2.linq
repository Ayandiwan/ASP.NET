<Query Kind="Program" />

void Main()
{
    string input = "   Hello    How    Are   You     ";

    "Input :".Dump();
    input.Dump();

    string output = input.RemoveExtraSpaces();

    "Output :".Dump();
    output.Dump();
}

// ===============================
// Extension Method for LINQPad
// ===============================
public static class StringExtensions
{
    public static string RemoveExtraSpaces(this string value)
    {
        return string.Join(" ",
            value.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries));
    }
}
