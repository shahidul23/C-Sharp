using System;
class GradeCalculator
{
    public static void Main(string[] args)
    {
        int marks;
        Console.Write("Enter Number:");
        marks = Convert.ToInt32(Console.ReadLine());

        if (100 >= marks && marks >=90)
        {
            PrintGrade('A');
        }else if(89 >= marks && marks >=80)
        {
            PrintGrade('B');
        }else if(79 >= marks && marks >=70)
        {
            PrintGrade('C');
        }else if (69 >= marks && marks >= 60)
        {
            PrintGrade('D');
        }else if(59 >= marks && marks >= 0)
        {
            PrintGrade('F');
        }else
        {
            Console.WriteLine("Invalide Input");
        }

    }
    public static void PrintGrade(char grade)
    {
        Console.WriteLine($"Your Grade is : {grade}");

    }
    
}