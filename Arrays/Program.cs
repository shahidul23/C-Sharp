using System;
class DataStructure
{
    public static void Main(string[] args)
    {
        // StringArray();
        // IntegerArray();
        // PositiveArraySum();
        // MultidimensionalArray();
        // JaggedArray();
        ArrayInput();
        
    }
    static void StringArray()
    {
        string[] names = {"Md", "Shahidul", "islam", "Shohan", "Khan"};
        // for(int i =0; i< names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }
    static void IntegerArray()
    {
        int[] numbers = {1,2,3,4,5,6,7,8,9};
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number; 
            Console.WriteLine(sum);
        }
        Console.WriteLine($"Total Sum :  {sum}");
    }
    static void PositiveArraySum()
    {
        int[] numbers = {-1,2,3,4,-5,6,7,-8,9};
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine(number);
            }
        }
    }
    static void MultidimensionalArray()
    {
        Console.WriteLine("Enter Row Number:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Column Number:");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for(int i = 0; i< rows; i++)
        {
            for(int j = 0; j<cols; j++)
            {
                Console.Write("Enter Value : ");
                int num = Convert.ToInt32(Console.ReadLine());
                matrix[i,j] = num;
            }
        }

        for(int row = 0; row<rows; row++)
        {
            for(int col = 0; col<cols; col++)
            {
                Console.Write($"{matrix[row, col]}, ");
            }
            Console.WriteLine("");
        }
    }
    static void JaggedArray()
    {
        try
        {
            // int [][] array = new int [][]
            // {
            //   new int[] {1,2,3},  
            //   new int[] {6,2,3,5,9,2},
            //   new int[] {1,3},
            //   new int[] {2,0,3,5,3},
            // };
             int [][] array =
            {
              new [] {1,2,3},  
              new [] {6,2,3,5,9,2},
              new [] {1,3},
              new [] {2,0,3,5,3},
            };

            // for(int row = 0; row < array.Length; row++)
            // {
            //     for(int col = 0; col<array[row].Length; col++)
            //     {
            //         Console.Write($"{array[row][col]} ");
            //     }
            //     Console.WriteLine("");
            // }
            foreach (var row in array)
            {
                foreach (var item in row)
                {
                     Console.Write($"{item} ");
                }
                Console.WriteLine("");
            }
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine($"Error: Pleace enshure Array Length:{e.Message} ");
        }catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        
    }
    static void ArrayInput()
    {
        try
        {
            Console.Write("Enter array size:");
            int size = ValideInteger();

            int[] numbers = new int[size];
           
            for(int i = 0; i< numbers.Length; i++)
            {
                Console.Write($"Enter element {i + 1}:");
                
                numbers[i] = ValideInteger();
            }

            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            int maxValue = max(numbers);
            Console.WriteLine($"Max Number: {maxValue}");
            int minValue = min(numbers);
            Console.WriteLine($"Min Number: {minValue}");
            int arraySum = ArraySum(numbers);
            Console.WriteLine($"Element Sum : {arraySum}");
            double arrayAvg = ArrayAvarage(numbers); 
            Console.WriteLine($"Element Avg: {arrayAvg}");

        }
        
        catch (OutOfMemoryException)
        {
            Console.WriteLine($"Out of memory, Unable to create arrays larges drymension");
        }catch(Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
    public static int ValideInteger()
    {
        while (true)
        {
            string value = Console.ReadLine()?? "";
            if (int.TryParse(value, out int result))
            {
                return result;
            }else
            {
                Console.WriteLine($"Invalide input! Pleace enter a valide Integer.");
            }
        }
    }
    public static int max (int[] numbers)
    {
        int max = numbers[0];
        for(int i = 1; i<numbers.Length; i++)
        {
            if(max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }
    public static int min (int[] numbers)
    {
        int min = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }
    public static int ArraySum (int[] numbers)
    {
        int sum = 0;
        foreach(int val in numbers)
        {
            sum +=val;
        }
        return sum;
    }
    public static double ArrayAvarage(int[] numbers)
    {
        int sum = 0;
        foreach(int val in numbers)
        {
            sum +=val;
        }
        return sum / numbers.Length;
    }
    
}