class Student
{
    public string Name {
        private set;
        get;
    }
    public DateTime DateOfBrith{
        private set;
        get;
    }
    public string RollNumber {
        private set;
        get;
    }
    // public int Age
    // {
    //     get
    //     {
    //         return CalculateAge();
    //     }
    // }
    public int Age => CalculateAge();
    public Student(string name, DateTime dateOfBrith, string rollNumber) {
        VlaidateInput(name, dateOfBrith, rollNumber);
        
        Name = name;
        DateOfBrith = dateOfBrith;
        RollNumber = rollNumber;
    }
    private  static void VlaidateInput(string name, DateTime dateOfBrith, string rollNumber)
    {
         if(string.IsNullOrWhiteSpace(rollNumber))
        {
            throw new ArgumentException ("Roll Number can not be null or empty.");
        }
         if(dateOfBrith > DateTime.Now)
        {
            throw new ArgumentException ("Date of Brith Can not be in the feuture.");
        }
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException ("Name can not be null or empty.");
        }
        if(dateOfBrith == default)
        {
            throw new ArgumentException ("Date of brith can not be null");
        }
    }

    // private int CalculateAge()
    // {
    //     int age = DateTime.Now.Year - DateOfBrith.Year;
    //     if (DateTime.Now < DateOfBrith.AddYears(age))
    //     {
    //         age --;
    //     }
    //     return age;
    // }
    private int CalculateAge()
    {
        int age = DateTime.Now.Year - DateOfBrith.Year;
        return DateTime.Now < DateOfBrith.AddYears(age) ? age--: age;
    }
    public void PrintDetailes()
    {
        Console.WriteLine($"Student Detailes: Name :{Name}, Date Of Brith: {DateOfBrith.ToShortDateString()} and Roll Number : {RollNumber} Age : {Age}");
    }
}