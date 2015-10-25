using System;
class Program
{
    static void Main()
    {
        for (int i = 2; i <= 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine("{0} of " + (char)3 + ", {0} of " + (char)4 + ", {0} of " + (char)5 + ", {0} of " + (char)6 + ".", i);
            }
            else
            {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                    {
                        case 11: Console.WriteLine((char)3 + "D " + (char)4 + "D " + (char)5 + "D " + (char)6 + "D "); break;
                        case 12: Console.WriteLine((char)3 + "A " + (char)4 + "A " + (char)5 + "A " + (char)6 + "A "); break;
                        case 13: Console.WriteLine((char)3 + "J " + (char)4 + "J " + (char)5 + "J " + (char)6 + "J "); break;
                        case 14: Console.WriteLine((char)3 + "K " + (char)4 + "K " + (char)5 + "K " + (char)6 + "K "); break;
                    }
            }
        }
    }
}

/*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
  The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
  The card faces should start from 2 to A.
  Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and 
  a switch-case statement.*/