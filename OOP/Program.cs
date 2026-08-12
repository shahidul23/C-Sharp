class MainClass
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Md Shaidul Islam", 28);
        p1.DisplayInfo();
        Person p2 = new Person("Tripty", 21);
        p2.DisplayInfo();
        Person p3 = new Person();
        p3.DisplayInfo();

    }
}
