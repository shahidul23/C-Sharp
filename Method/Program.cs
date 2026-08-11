using System;
class MainClass
{    public static void Main(string[] args)
    {
        // Add(4,6);
        // int result = Squire(5);
        // Console.WriteLine(result);
        Validation();
    }
    public static void Add(int numOne, int numTwo)
    {
        Console.WriteLine(numOne + numTwo);
    }
    public static int Squire(int num)
    {
        return num*num;
    }

    public static void Validation()
    {
        while (true)
        {
            Console.WriteLine("Enter Number 1 to 10 or quit:");
            string input = Console.ReadLine() ?? "";
            input.ToLower().Trim();
            if (input == "quit")
            {
                Console.WriteLine("Termanited this Functoin");
                break;
            }
            if(!int.TryParse(input, out int num))
            {
                Console.WriteLine("Enter Valide input, Pleace Try again");
                continue;
            }
            if(num >= 10 && num <= 1)
            {
                Console.WriteLine("Pleace Choose a number. not a range");
                continue;
            }
            
            int squire = GetSquireNumber(num);
            Console.WriteLine($"This {num} Squire value is : {squire}");
        }
    }
    public static int GetSquireNumber(int num)
    {
        return num * num;
    }

}