using System;
class LINQPartTwo
{
    public static void Main(string[] args)
    {
        // sortedOperator();
        // SortedArrayUsingObject();
        // Quantifiers();  
        Aggregation();
    }
    static void sortedOperator()
    {
        int[] numbers = {2,5,3,8,9,1};
        var sortedNumber = numbers.OrderBy(num => num);
         foreach (var item in sortedNumber)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

    }
    static void SortedArrayUsingObject()
    {
        List<Preson> presons = new List<Preson>
        {
            new Preson {Name="Shaidul", Age=27},
            new Preson {Name = "Aksah", Age = 27},
            new Preson {Name = "Najmul", Age= 34},
            new Preson {Name = "Al Amin", Age =29}
        }; 

        var sortPerson = presons.OrderBy(person => person.Age).ThenBy(person =>person.Name);
        foreach (var item in sortPerson)
        {
            Console.WriteLine($"{item.Name} {item.Age}");
        }
    }
    static void Quantifiers()
    {
        List<Preson> presons = new List<Preson>
        {
            new Preson {Name="Shaidul", Age=27},
            new Preson {Name = "Aksah", Age = 27},
            new Preson {Name = "Najmul", Age= 34},
            new Preson {Name = "Al Amin", Age =17}
        }; 

        bool AllAdult = presons.All(person => person.Age >=18);

       
        Console.WriteLine($"{AllAdult}");

        bool AnyteenAger = presons.Any(person => person.Age <18);

        Console.WriteLine($"{AnyteenAger}");

        bool containeAlice = presons.Select(person => person.Name).Contains("Shaidul");

        Console.WriteLine($"{containeAlice}");

    }
    static void PrintArray(int[] numbers)
    {
        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
    static void Aggregation()
    {
        int[] numbers = {1,2,3,4,5,6,7};

        int sum = numbers.Sum();
        int max = numbers.Max();
        int min = numbers.Min();
        int count = numbers.Count();
        double avg = numbers.Average();

        Console.WriteLine($"{sum}, {max}, {min}, {count}, {avg}");
    }
}