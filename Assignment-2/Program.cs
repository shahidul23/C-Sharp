using System;
class AssingmentTwo
{
    public static void Main(string[] args)
    {
        string? studentName;
        int age;
        double CGPA;
        bool? isRegistart = false;

        Console.Write("Enter Student name:");
        studentName = Console.ReadLine();
        Console.Write("Enter Age:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter CGPA:");
        CGPA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Student Registard or not: write true or false");
        isRegistart = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("My Name is "+ studentName + ", my age is "+ age + ", CGPA is ,"+ CGPA+", Also Im Registart :"+ isRegistart);

    }
}