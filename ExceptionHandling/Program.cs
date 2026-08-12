using System;
class ExceptionHandling
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Welcome to the Calculator:");
        try
        {
            int num1 = ReadIntegerInput("num1");
            int num2 = ReadIntegerInput("num2");
            if(num2>1000)
            {
                throw new ArgumentException($"Number two can not be greatern then 1000");
            }

            double div = num1/num2;
            Console.WriteLine($"Print {div}");
        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
        
    }
    static int ReadIntegerInput_old(string prompt)
    {
        while(true)
        {  
            try
            {
                Console.Write($"Enter {prompt}:");
                string input = Console.ReadLine() ?? "";
                
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentNullException($"{prompt} Can not be null or Empty.");
                }
                return Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Exception: Invalide input! Pleace enter a valid interger.");
                continue;
            }catch (ArgumentNullException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                continue;
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                continue;
            }
        }
       
    }

    static int ReadIntegerInput(string prompt)
    {
        while(true)
        {  
            Console.Write($"Enter {prompt}:");
            string input = Console.ReadLine() ?? "";
            
            if (!int.TryParse(input, out int result) || string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"Invalide Input! Pleace enter a valide integer.");
                continue;
            }
            return result;
            
        }
       
    }
}