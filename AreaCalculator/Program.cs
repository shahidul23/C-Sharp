using System;
class AreaCalculator
{
    public static void Main(string[] args)
    {
        ShowMainMenu();
    }
    public static void ShowMainMenu()
    {
        Console.WriteLine("Show Main Menu");
        Console.WriteLine("1. Triangle.");
        Console.WriteLine("2. Rectangle.");
        Console.WriteLine("3. Trapezium.");
        Console.WriteLine("4. Ellipse.");
        Console.WriteLine("5. Square.");
        Console.WriteLine("6. Parallelogram.");
        Console.WriteLine("7. Circle.");
        Console.WriteLine("8. Sector.");
        Console.WriteLine("0. Exit.");
        Console.Write("\nChoose Any Number:");

        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ShowTriangle();
                break;
            case "2":
                ShowRectangle();
                break;
            case "3":
                ShowTrapezium();
                break;
            case "4":
                ShowEllipse();
                break;
            case "5":
                ShowSquare();
                break;
            case "6":
                ShowParallelogram();
                break;
            case "7":
                ShowCircle();
                break;
            case "8":
                ShowSector();
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Press Enter to retry.");
                Console.Write("\nChoose Any Number:");
                Console.ReadLine();
                ShowMainMenu();
                break;
        }
    }
    static void ShowTriangle()
    {
        double area, baseNumber, height;
        Console.Write("Enter Base: ");
        baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Height: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = 0.5 * baseNumber * height;
        Console.WriteLine($"The Triangle is :{area.ToString("F2")}");
        ShowMainMenu();
    }
    static void ShowRectangle()
    {
        double area, height, width;
        Console.Write("Enter Width: ");
        width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Height: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = width * height;

        Console.WriteLine($"The Rectangle is : {area.ToString("F2")}");
        ShowMainMenu();
    }
    static void ShowTrapezium()
    {
        double area, baseOne, baseTwo, verticalHeight;

        Console.Write("Enter base one: ");
        baseOne = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter base tow: ");
        baseTwo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter vartical height: ");
        verticalHeight = Convert.ToDouble(Console.ReadLine());

        area = 0.5 *(baseOne + baseTwo) * verticalHeight;
        Console.WriteLine($"The Trapezium is : {area.ToString("F2")}");
        ShowMainMenu();
    }
    static void ShowEllipse()
    {
        double area, baseOne, baseTwo;
        Console.Write("Enter base one: ");
        baseOne = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter base tow: ");
        baseTwo = Convert.ToDouble(Console.ReadLine());

        area = 3.1415 * baseOne * baseTwo;

        Console.WriteLine($"The Ellipse is: {area.ToString("F2")}");
        ShowMainMenu();
    }
    static void ShowSquare()
    {
        double area, side;
        Console.Write("Length of Side: ");
        side = Convert.ToDouble(Console.ReadLine());

        area = side * side;

        Console.WriteLine($"The Square is : {area.ToString("F3")}");
        ShowMainMenu();
    }
    static void ShowParallelogram()
    {
        double area, baseNumber, height;
        Console.Write("Enter Base: ");
        baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Vartical Height: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = baseNumber * height;

        Console.WriteLine($"The Parallelogramd is :{area.ToString("F2")}");
        ShowMainMenu();

    }
    static void ShowCircle()
    {
        double area, radius;
        Console.WriteLine("Enter Radius: ");
        radius = Convert.ToDouble(Console.ReadLine());

        area = 3.1415 * (radius * radius);
        Console.WriteLine($"The Circle is : {area.ToString("F2")}");
        ShowMainMenu();
    }
    static void ShowSector()
    {
        double area, radius, degrees, angleInRadians;
        Console.WriteLine("Enter Radius: ");
        radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Angle (in degrees): ");
        degrees = Convert.ToDouble(Console.ReadLine());

        angleInRadians = degrees * (Math.PI / 180.0);

        area = 0.5 * (radius * radius) * angleInRadians;
        Console.WriteLine($"The sector is : {area.ToString("F2")}");
        ShowMainMenu();
    }

}