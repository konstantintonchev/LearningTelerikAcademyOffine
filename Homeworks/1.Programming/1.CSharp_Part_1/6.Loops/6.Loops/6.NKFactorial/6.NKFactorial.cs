using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k:");
        int k = int.Parse(Console.ReadLine());
        int nFakturial = 1;
        int kFakturial = 1;

        if (n > k)
        {
            for (int i = 1; i <= n; i++)
            {
                nFakturial *= i;
                if (i <= k)
                {
                    kFakturial *= i;
                }
            }
            Console.WriteLine("n! is = {0}", nFakturial);
            Console.WriteLine("k! is = {0}", kFakturial);
        }
        else
        {
            Console.WriteLine("n must be greather than k!!!");
        }
    }
}

//Write a program that calculates n! / k! for given n and k(1 < k<n< 100). Use only one loop.

