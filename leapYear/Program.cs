using System;
class LeapYear
{
    public static void Main(string[] args)
    {
        int year;
        Console.Write("Enter Years: ");
        year = Convert.ToInt32(Console.ReadLine());

        if(year % 400 == 0 || year % 4 == 0 && year %100 != 0)
        {
            Console.WriteLine($"{year} leap Year");
        }
        else
        {
            Console.WriteLine($"{year} not Leap Years");
        }
    }
}