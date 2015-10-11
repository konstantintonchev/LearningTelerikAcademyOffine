using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        for (char i =(char)001; i < 255; i++)
        {
            Console.WriteLine(i);
        }
    }
}