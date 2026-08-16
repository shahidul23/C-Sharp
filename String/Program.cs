using System;
class StringClass
{
    public static void Main(string[] args)
    {
        // StringIntroduction();
        Assignment();
    }
    public static void StringIntroduction()
    {
        string text = "   My name is Shahdiul  ";
        Console.WriteLine($"Length of String:{text.Length}");
        Console.WriteLine($"1 index of String:{text[1]}");

        string remove = text.Remove(2, 6);
        Console.WriteLine($"Remove String: {remove}");

        string replace = text.Replace("   ", "Hello, ");
        Console.WriteLine($"Replace String: {replace}");

        bool isExists = text.Contains("name");
        Console.WriteLine($"Existing String: {isExists}");

        string reverseString  = new string(text.Reverse().ToArray());
        Console.WriteLine($"Reverse String: {reverseString}");

        bool isEmpty = string.IsNullOrEmpty(text);
        Console.WriteLine($"String is null or Empty: {isEmpty}");
        string insert = text.Insert(0,"Hi !");
        Console.WriteLine($"String is Insert: {insert}");
        string upper = text.ToUpper();
        Console.WriteLine($"String is UperCase: {upper}");
        string lower = text.ToLower();
        Console.WriteLine($"String is LowerCase: {lower}");
        string trimmedString = text.Trim();
        Console.WriteLine($"Trimed String: {trimmedString}");
        string SubString = trimmedString.Substring(3, 6);
        Console.WriteLine($"Sub String: {SubString}");

        var ward = text.Split(" ");
        Console.WriteLine(string.Join(",", ward));
         
        Console.ReadKey();
    }

    public static void Assignment()
    {
        string input = "Shahidul islam";
        int vowelCount = input.Count(c => "aeiouAEIOU".Contains(c));
        int consonentCount = input.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
        Console.WriteLine($"Vowel: {vowelCount}");
        Console.WriteLine($"Consonent : {consonentCount}");

        int digitCount = input.Count(char.IsDigit );
        Console.WriteLine($"Digit : {digitCount}");
        int specialChar = input.Count(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
        Console.WriteLine($"Special : {specialChar}");
        int whiteSpace = input.Count(char.IsWhiteSpace);
        Console.WriteLine($"White Sapce : {whiteSpace}");

        int WordCount  = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"Word Connection  : {WordCount}");
    }
}