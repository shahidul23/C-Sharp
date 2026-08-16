using System;
class MainClass
{
    public static void Main(string[] args)
    {
        try
        {
            Student studentOne = new Student("Shahidul islam", new DateTime(1998, 6, 23), "2017200000034"); 
            Student studentTwo = new Student("Shohan Kahn", new DateTime(1996, 9, 03), "2017300000004");

            studentOne.PrintDetailes();
            studentTwo.PrintDetailes();
           
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
    
}