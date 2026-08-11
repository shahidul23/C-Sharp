using System;
class Assignment
{
    public static void Main(string[] args)
    {
        // DayFind();
        // switchSort();
        // findOutType();
        // findOutTypeSort();
        // SwitchWithCondition();
        // TemparatureConvater();
        BasicCalculator();
    } 

    static void DayFind()
    {
        Console.Write("Enter a day of week : ");
        string? day = Convert.ToString(Console.ReadLine());

        switch (day.ToLower())
        {
            case "saturday":
            case "sunday":
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
                Console.WriteLine("Working Day");
                break;
            case "friday":
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Not a Valide Day");
                break;
        }
    }
    static void switchSort()
    {
        Console.Write("Enter a day of week : ");
        string? day = Convert.ToString(Console.ReadLine());

        string result = day switch
        {
            "saturday"  => "Working Day",
            "sunday"  => "Working Day",
            "monday"  => "Working Day",
            "tuesday"  => "Working Day",
            "wednesday"  => "Working Day",
            "thursday"  => "Working Day",
            "friday"  => "Weekend Day",
            _ => "Not a Valide Day"

        };
        Console.WriteLine(result);
    }
    static void findOutType()
    {
        object number = 10;
        switch (number)
        {
            case int:
                Console.WriteLine($"Integet");
                break;
            case double:
                Console.WriteLine($"Double");
                break;
            case bool:
                Console.WriteLine($"Bollein");
                break;
            case string:
                Console.WriteLine($"String");
                break;
            default:
            Console.WriteLine($"Unkniwn Type");
                break;
        }
    }
    static void findOutTypeSort()
    {
        object number = "Helllo";

        string result = number switch
        {
            int => "Integer",
            double => "Double",
            string => "String",
            char => "Char",
            bool => "Bollein",
            _ => "Unknown"
        };
        Console.WriteLine(result);
        Console.ReadKey();
 
   }

    static void SwitchWithCondition()
    {
        int number;
        Console.Write("Enter a number 1 to 50 : ");
        number = Convert.ToInt32(Console.ReadLine());

        string result = number switch
        {
            int num when 50 < num && num > 1 => "Out of Range",
            int num when num % 2 == 0 => "Even Number",
            int num when num % 2 != 0 => "Odd Number",
            _ => "Unknown",
        };
        Console.WriteLine(result);
    }
    static void TemparatureConvater()
    {
        Console.WriteLine("Temperature Converter Start");
        Console.WriteLine("1. Fahrenhite to Celsius.");
        Console.WriteLine("2. Celsius to Fahrenhite.");
        Console.WriteLine("0. Exit");
        Console.Write("\nChoose Any Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        switch(number)
        {
            case 1:
                Console.Write("Enter Fahrenhite temperature: ");
                double fahrOne = Convert.ToDouble(Console.ReadLine());
                double celsOne = (fahrOne - 32)/1.8;
                Console.WriteLine(celsOne);
                break;
            case 2:
                Console.Write("Enter Celsius temperature: ");
                double celsTwo = Convert.ToDouble(Console.ReadLine());
                double fahrTwo = (celsTwo * 1.8)+32;
                Console.WriteLine(fahrTwo);
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalide Numer");
                break;    
        } 
    }
    static void BasicCalculator()
    {
        Console.Write("Enter Number One:");
        int numOne = Convert.ToInt32(Console.ReadLine());
         Console.Write("Enter Number Two:");
        int numTwo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Choose Operator (+,-,/,*):");
        char? Operator = Convert.ToChar(Console.ReadLine());

        switch (Operator)
        {
            case '+':
                double sum = numOne + numTwo;
                Console.WriteLine(sum);
                break;
            case '-':
                double sub = numOne - numTwo;
                Console.WriteLine(sub);
                break;
            case '*':
                double mul = numOne * numTwo;
                Console.WriteLine(mul);
                break;
            case '/':
                double div = numOne / numTwo;
                Console.WriteLine(div);
                break;
            default:
                Console.WriteLine("Invalide");
                break;        
        }

    }
} 