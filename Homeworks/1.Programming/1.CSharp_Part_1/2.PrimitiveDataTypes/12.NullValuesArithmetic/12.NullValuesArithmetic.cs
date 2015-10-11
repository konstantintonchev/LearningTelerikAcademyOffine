using System;
class Program
{
    static void Main()
    {
        int? val1 = null;
        double? val2 = null;
        Console.WriteLine(val1);
        Console.WriteLine(val2);
        Console.WriteLine(val1 = 5);
        Console.WriteLine(val2 = 10);
    }
}


//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
