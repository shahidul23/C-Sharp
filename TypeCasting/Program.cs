using System;
class TypeCasting
{
    
    public static void Main(string[] str)
    {
        string salary = "2344.23";
        double salaryDub = Convert.ToDouble(salary);
        Console.WriteLine(salaryDub);
        int salaryInt = Convert.ToInt16(salaryDub);
        Console.WriteLine(salaryInt);
        bool isSuccess = int.TryParse(salary, out int result);
        Console.WriteLine(isSuccess);
        Console.WriteLine(result);
    }
}
/*
// Implicit / Automatic Conversion
char -> int -> long -> float -> double 

// Explicit / manual Conversion
double -> float -> long -> int -> char
*/