using System;
using System.Runtime.Intrinsics.Arm;
class ObjectOrientedProgramming
{
    public static void Main(string [] args)
    {
        Student std = new Student(34);

        Console.WriteLine(std.age);
        // Person p1 = new Person();
        // p1.Name = "Md. Shahidul Islam";

        // p1.Age =23;

        // Console.WriteLine($"name :{p1.Name} and Age: {p1.Age}");
    }
}