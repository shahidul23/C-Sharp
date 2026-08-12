using System;
class Person
{
    public string name;
    public int age;
    public Person()
    {
        name = "test";
        age = 0;
    }
    public Person(string n, int a)
    {
        name = n;
        age = a;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name} and , Age is {age}\n");
    }
}