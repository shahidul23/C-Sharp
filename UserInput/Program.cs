using System;
class UserInput
{
    public static void Main(string[] str)
    {
        string? studentName;
        int age;
        Console.Write("Enter Student Name:");
        studentName = Console.ReadLine();
        Console.WriteLine("Welcome :" + studentName);

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Student Age:" + age + " years Old");

    }
}