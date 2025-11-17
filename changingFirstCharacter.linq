<Query Kind="Program" />

public static class MyExtensions
{
    // Extension method to change the first character of a string
    public static string ChangeFirstChar(this string str, char newChar)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        return newChar + str.Substring(1);
    }
}

void Main()
{
    // Example string
    string original = "ayan";

    // Call the extension method
    string changed = original.ChangeFirstChar('A');

    // Show results in LINQPad
    "Original String:".Dump();
    original.Dump();

    "Changed String:".Dump();
    changed.Dump();
}
