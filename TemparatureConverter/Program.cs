using System;
class Temperature
{
    public static void Main()
    {
        FahrenthitTOCelsius();
    }
    static void FahrenthitTOCelsius()
    {
        double fahrenthit, celsius;
        Console.Write("Enter Fahrenthit: ");
        fahrenthit = Convert.ToDouble(Console.ReadLine());

        celsius = (fahrenthit - 32) / 1.8;

        Console.WriteLine($"Celsius : {celsius:F2}");
    }
    static void CelsiusToFahernthite()
    {
        double fahrenthit, celsius;
        Console.Write("Enter celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        fahrenthit = (celsius * 1.8) + 32;
        Console.WriteLine($"Fahrenthit is : {fahrenthit:F2}");
    }
}