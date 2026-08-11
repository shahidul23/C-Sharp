using System;
class WhileLoopStatement
{
    public static void Main(string[] args)
    {
        // WhileLoop();
        // DoWhileLoop();
        // BreakAndContiner();
        // nestedLoop();
        Multipaction();
    }
    static void WhileLoop()
    {
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }
    static void DoWhileLoop()
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        }while(i<=5);
    }
    static void BreakAndContiner()
    {
        for(int i =0; i<=100; i++)
        {
            if(i % 2 != 0)
            {
                continue;
            }else if(i == 96)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
    static void nestedLoop()
    {
        for(int i=1; i<=5; i++)
        {
            for(int j = i; j <=5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    static void Multipaction()
    {
        Console.Write("Enter a numer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i<=10; i++)
        {
            int mul = num * i;
            Console.WriteLine($"{num} X {i} = {mul}");
        }
    }
}