using System;
class AssignmentOperators
{
    public static void Main(string[] args)
    {
        // AssignmentArathmeticOperators();
        // RelationalOperator();
        // RelationalOperatorCheck();
        // LogicalOperator();
        BitwiseOperatores();
        UnaryOperators();
        TernaryOperator();
    } 
    static void AssignmentArathmeticOperators()
    {
        int number = 20;

        number +=5;
        Console.WriteLine(number);
        number -=5;
        Console.WriteLine(number);
        number *=5;
        Console.WriteLine(number);
        number /=5;
        Console.WriteLine(number);
        number %=3;
        Console.WriteLine(number);

    }
    static void RelationalOperatorCheck()
    {
        int numOne = 20;
        int numTwo = 20;
        int numThree = 25;

        Console.WriteLine(numThree >= numTwo);
        Console.WriteLine(numOne == numTwo);
        Console.WriteLine(numOne != numTwo);
        Console.WriteLine(numOne != numThree);
        Console.WriteLine(numOne <= numTwo);
    }
    static void RelationalOperator()
    {
        int numberOne = 20;
        int numberTwo = 30;
        int numberThree = 18;
        int result;

        if(numberOne > numberTwo && numberOne > numberThree)
        {
            result = numberOne;
        }else if(numberTwo > numberOne && numberTwo > numberThree)
        {
            result = numberTwo;
        }else
        {
            result = numberThree;
        }
        Console.WriteLine("Greter Number: "+result);
    }
    static void LogicalOperator()
    {
        Console.WriteLine(8>6 && 5<9 && 23 > 31);
        Console.WriteLine(8>9 || 10<9 || 23 > 31);
        Console.WriteLine(!(8>6 && 5<9 && 23 > 31));
    }
    static void BitwiseOperatores()
    {
        int numOne = 15;
        int numTwo = 10;
        int result;

        result = numOne & numTwo;
        Console.WriteLine("{0} & {1} = {2}", numOne, numTwo, result);

        result = numOne | numTwo;
        Console.WriteLine("{0} | {1} = {2}", numOne, numTwo, result);

        result = numOne ^ numTwo;
        Console.WriteLine("{0} ^ {1} = {2}", numOne, numTwo, result);

        result = numOne >> 2;
        Console.WriteLine("{0} >> {1} = {2}", numOne, 2, result);

        result = numOne << 2;
        Console.WriteLine("{0} << {1} = {2}", numOne, 2, result);

    }

    static void UnaryOperators()
    {
        int number = 10;
        Console.WriteLine(number ++);    //10
        Console.WriteLine(number ++); // 11
        Console.WriteLine(number); // 12
        Console.WriteLine(number --); // 12
        Console.WriteLine(number --); // 11
        Console.WriteLine(--number); // 9
        Console.WriteLine(-number); // -9
    }

    static void TernaryOperator()
    {
        int numOne = 10;
        int numTwo = 15;
        
        int result = numOne > numTwo ? numOne : numTwo;
        Console.WriteLine(result);
    }

}