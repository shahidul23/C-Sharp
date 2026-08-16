using System;
class ShallowDeepCopy
{
    public static void Main(string[] args)
    {
        
        // ShallowArray();
        DeepArray();
    }

    static void DeepArray()
    {
        int[] originalArray = {1,2,3,4,5,6,7};
        int[] deepArray = new int[originalArray.Length];
        Array.Copy(originalArray, deepArray, originalArray.Length);

        Console.WriteLine($"Orginal Array Befor modifiaction :");
        PrintArray(originalArray);
        Console.WriteLine($"deep Array Befor modifiaction :");
        PrintArray(deepArray);

        deepArray[0] =10;
        Console.WriteLine($"Orginal Array after modifiaction :");
        PrintArray(originalArray);
        Console.WriteLine($"deep Array after modifiaction :");
        PrintArray(deepArray);
    }

    static void ShallowArray()
    {
        int[] originalArray = {1,2,3,4,5,6,7};
        int[] shallowArray = originalArray;
        Console.Write("Original Array: ");
        PrintArray(originalArray);
        Console.Write("Shallow Array: ");
        PrintArray(shallowArray);

        shallowArray[0] = 10;

        Console.Write("Original Array: ");
        PrintArray(originalArray);
        Console.Write("Shallow Array: ");
        PrintArray(shallowArray);
    }



    static void PrintArray(int[] numbers)
    {
        foreach (int item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}