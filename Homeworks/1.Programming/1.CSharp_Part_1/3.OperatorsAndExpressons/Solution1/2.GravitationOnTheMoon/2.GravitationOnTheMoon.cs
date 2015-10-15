using System;

class Program
{
    static void Main()
    {
        inputWeight:
        Console.Write("Pleace enter your weight in kg: ");
        double manWeightOnEarth = double.Parse(Console.ReadLine());
        double manWeightOnMoon = (manWeightOnEarth / 1.17);
        Console.WriteLine("Your weight on the moon will be: {0} kg.", Math.Round(manWeightOnMoon, 2));
        goto inputWeight;
    }
}



//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
