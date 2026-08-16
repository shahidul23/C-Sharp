using System;
using System.ComponentModel;
class ArrayPartTwo
{
    public static void Main(string[] args)
    {
        // ArrayProperty();
        ParamsMethod();
    }
    public static void ArrayProperty()
    {
        int [] number = {3,2,4,5,6,7};
        Console.WriteLine($"Length of Array: {number.Length}");
        Console.WriteLine($"Length of Array: {number.Rank}");
        Console.WriteLine($"maxium Value Of the array:" + number.Max());
        Console.WriteLine($"Minimum Value Of the array:" + number.Min());
        Console.WriteLine($"Sum Value Of the array:" + number.Sum());
        Console.WriteLine($"Avarage Value Of the array:" + number.Average());
        Console.WriteLine($"Befor Shorting");
        Array.Sort(number);
        PrintArray(number);
        Console.WriteLine($"After Shorting");
        Console.WriteLine($"Befor Reversing");
        Array.Reverse(number);
        PrintArray(number);
        Console.WriteLine($"Arter Reversing");


        int index = Array.IndexOf(number,4);
        Console.WriteLine($"Array Index :{index}");

        bool exists = Array.Exists(number, num => num == 3);
        Console.WriteLine($"Dose Array Value 3?: {exists}");

        int[] copy = new int [number.Length];
        Array.Copy(number, copy, number.Length);
        Console.Write("Print Copy Array: ");
        
        PrintArray(copy);
        Array.Clear(copy, 0, copy.Length);
        Console.Write($"Clear Array : ");
        PrintArray(copy);


        Console.ReadKey(); 
    }
    public static void PrintArray(int[] number)
    {
        for(int i  = 0; i<number.Length; i++)
        {
            Console.Write($"{number[i]} ");
        }
        Console.WriteLine();

    }
    public static void ParamsMethod()
    {
        Console.WriteLine(Sum(45, 34, 34, 34, 67,34));
        Console.WriteLine(Sum(45, 34, 34, 34));
    }
    public static int Sum(params int [] numbers)
    {
        int sum = 0;
        foreach(int num in numbers)
        {
            sum+=num;
        }
        return sum;
    }
}