using System;
class Program
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object sentence = firstWord + ' ' + secondWord;
        string secondSentence = (string)sentence;
        Console.WriteLine(sentence);
        Console.WriteLine(secondSentence);
        
    }
}