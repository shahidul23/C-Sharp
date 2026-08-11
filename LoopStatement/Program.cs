using System;
class LoopStetament
{
    public static void Main(string[] args)
    {
        // IntoductLoop();
        // Serice();
        // EvenPrint();
        // SumEven();
        // SumOdd();
        FactorialNumber();
    }
    static void IntoductLoop()
    {
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Hello");
        }
    }
    static void Serice ()
    {
        Console.Write("Enter Last Number : ");
        int numer = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <=numer; i++)
        {
            Console.WriteLine($"{i} print");
        }
    }
    static void EvenPrint()
    {
        Console.Write("Enter number:");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i <= num; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine($"Even Number - {i}");
            }
        }
    }
    static void SumEven()
    {
        int sum = 0;
        Console.Write("Enter Start Number: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter End Number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        for(int i = start; i <= end; i++)
        {
            if(i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);

    }
    static void SumOdd()
    {
        int sum = 0;
        Console.Write("Enter Start Number: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter End Number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        for(int i = start; i <= end; i++)
        {
            if(i % 2 != 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);

    }
    static void FactorialNumber()
    {
        int fact = 1;
        for(int i = 1; i<=5; i++)
        {
            fact *= i;
        }
        Console.WriteLine(fact);
    }
}