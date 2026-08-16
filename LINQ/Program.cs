using System;
class LanguageIntegrateQueries
{
    public static void Main(string[] args)
    {
        // FilterationWithWhere();
        // SrtingFilter();
        ClassObjectFilter();
    }
    static void FilterationWithWhere()
    {
        List<int> numbers = new List<int>{1,3,5,7, 8};

        var evenNumber = numbers.Where(num => num % 2 == 0 );
        Console.WriteLine($"Count of Even number : {evenNumber.Count()}");
        
        if (evenNumber.Any())
        {
            Console.WriteLine($"Even Number :");
            foreach(var item in evenNumber)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Not Event Number Found");
        }
        
    }
    static void SrtingFilter()
    {
        List<string> worlds = new List<string>{"Apple", "orange", "mango", "nanala"};
        var longWords = worlds.Where(world => world.Length > 5);

        Console.WriteLine($"Logn Words Count : {longWords.Count()}");

        if (longWords.Any())
        {
            foreach(var item in longWords)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

    }
    static void ClassObjectFilter()
    {
        List<Student> students = new List<Student>
        {
            new Student {Name= "Hasan", Score = 45},
            new Student {Name = "Manik", Score= 34},
            new Student {Name= "Aksah", Score = 89},
            new Student {Name = "kamal", Score= 88}
        };
        var highScore = students.Where(student => student.Score > 80);

        if (highScore.Any())
        {
            foreach (var item in highScore)
            {
                Console.WriteLine($"Name: {item.Name} and Score: {item.Score}");
            }
        }
    }
}