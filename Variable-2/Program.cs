using System;
using System.Reflection.Metadata;

class Variable
{
    public static void Main(string[] str)
    {
        // Constant Variable
        const string university = "Southeast University";
        Console.WriteLine(university);

        int num1, num2, num3;

        num1 = num2 = num3 = 10;

        int sum  = num1 * num2 * num3;

        Console.WriteLine(sum);
    }
}