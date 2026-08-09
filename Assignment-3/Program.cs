using System;
class Calculator
{
    public static void Main(string[] args)
    {
        int sum, sub, mul, rem, numberOne, numberTwo;
        double div, avg;
        Console.Write("Enter Number One:");
        numberOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number Two:");
        numberTwo = Convert.ToInt32(Console.ReadLine());

        sum = numberOne + numberTwo;
        Console.WriteLine($"{numberOne} + {numberTwo} = {sum}");
        sub = numberOne - numberTwo;
        Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, sub);
        mul = numberOne * numberTwo;
        Console.WriteLine($"{numberOne} * {numberTwo} = {mul}");
        div = (double)(numberOne / numberTwo);
        Console.WriteLine($"{numberOne} / {numberTwo} = {div.ToString("F2")}");
        rem = numberOne % numberTwo;
        Console.WriteLine("{0} % {1} = {2}", numberOne, numberTwo, rem);
        avg = (double)(numberOne + numberTwo) / 2;
        Console.WriteLine("{0} Avg {1} = {2}", numberOne, numberTwo, avg.ToString("F3"));


    }
}