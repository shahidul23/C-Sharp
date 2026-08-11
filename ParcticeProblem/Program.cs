using System;
class PracticeProblem
{
    public static void Main(string[] args)
    {
        // SmailAndCapital();
        findVowel();
        // switchCatch();
    }
    static void SmailAndCapital()
    {
        char? letter;
        Console.Write("Enter A Letter: ");
        letter = Convert.ToChar(Console.ReadLine());

        if (letter >= 'A' && letter <='Z')
        {
            Console.WriteLine($"{letter} is a Capital Letter");
        }else if (letter >= 'a' && letter <= 'z')
        {
            Console.WriteLine($"{letter} is a Small Letter");
        }else if(letter >= '0' && letter <='9')
        {
            Console.WriteLine($"{letter} is a Newmaric Letter");
        }
        else
        {
            Console.WriteLine($"{letter} is a Sepcial charecter");
        }
    }
    static void findVowel()
    {
        char letter;
        Console.Write("Enter A Letter: ");
        letter = Convert.ToChar(Console.ReadLine());

        switch (char.ToLower(letter))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{letter} is Vowel");
                break;
            default:
                if (char.IsLetter(letter))
                {
                    Console.WriteLine($"{letter} Is a Consonent");
                } else
                {
                    Console.WriteLine($"{letter} Is not a leater");
                };
                break;
        }

        // if (letter == 'A'||letter == 'E'||letter == 'I'||letter == 'O'||letter == 'U')
        // {
        //     Console.WriteLine($"{letter} is a vowel Letter");
        // }else if (letter == 'a'||letter == 'e'||letter == 'i'||letter == 'o'||letter == 'u')
        // {
        //     Console.WriteLine($"{letter} is a vowel Letter");
        // }else
        // {
        //     Console.WriteLine($"{letter} is a Consonant Letter");
        // }

    }
    static void switchCatch()
    {
        int digit;
        Console.WriteLine("Enter Digits: ");
        digit = Convert.ToInt32(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;        
            default:
                Console.WriteLine("Invalide");
                break;
        }
    }

}