using System;
class IfElseCondition
{
    public static void Main(string[] args)
    {
        Ifelse();
        DigitSpelling();
    }
    static void Ifelse()
    {
        int number = 0;
        if (number > 0)
        {
            Console.WriteLine("Positive Number");
        }else if (number < 0)
        {
            Console.WriteLine("negative Number");
        }else
        {
            Console.WriteLine("Zero");
        }
    }
    static void DigitSpelling()
    {
        int digit;
        Console.Write("Enter any digit between 0 to 9");
        digit = Convert.ToInt32(Console.ReadLine());

        if(digit == 0)
        {
            Console.WriteLine("Zero");
        }else if (digit == 1)
        {
            Console.WriteLine("One");
        }else if (digit == 2)
        {
            Console.WriteLine("Two");
        }else if (digit == 3)
        {
            Console.WriteLine("Three");
        }else
        {
            Console.WriteLine("Invalide Number");
        }

    }
}