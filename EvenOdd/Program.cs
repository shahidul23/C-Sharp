using System;
class EvenOdd
{
    public static void Main(string[] args)
    {
    //    FindOddAndEven();
    //    FindLargeNumber();
    FindLargeThreeNumber();
        
    }
    public static void FindOddAndEven()
    {
        int number;
        Console.Write("Enter Number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 )
        {
            Console.WriteLine($"This number id Even: {number}");
        }
        else
        {
            Console.WriteLine($"This number id Odd: {number}");
        }
    }

    public static void FindLargeNumber()
    {
        int numberOne, numberTwo;
        Console.Write("Enter Number One: ");
        numberOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number Two: ");
        numberTwo = Convert.ToInt32(Console.ReadLine());

        if (numberOne > numberTwo )
        {
            Console.WriteLine($"{numberOne} is Larger then {numberTwo}");
        }else if (numberOne == numberTwo)
        {
            Console.WriteLine($"{numberOne} and {numberTwo} are Equal");
        }else if (numberTwo > numberOne)
        {
            Console.WriteLine($"{numberTwo} is Larger then {numberOne}");
        }else
        {
            Console.WriteLine("Invalide Number");
        }
    }
    static void FindLargeThreeNumber()
    {
        int numberOne, numberTwo, numberTherr;
        Console.Write("Enter Number One: ");
        numberOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number Two: ");
        numberTwo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number Three: ");
        numberTherr = Convert.ToInt32(Console.ReadLine());

        if (numberOne > numberTherr && numberOne > numberTwo)
        {
            Console.WriteLine($"{numberOne} is lerger then {numberTwo} and {numberTherr}");
        }else if (numberTwo > numberOne && numberTwo > numberTherr)
        {
            Console.WriteLine($"{numberTwo} is lerger then {numberOne} and {numberTherr}");
        }else
        {
            Console.WriteLine($"{numberTherr} is lerger then {numberOne} and {numberTwo}");
        }
    }
}