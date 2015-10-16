using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Enter company web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Enter company manager name: ");
        string companyManagerName = Console.ReadLine();
        Console.Write("Enter company manager last name: ");
        string companyManagerLastName = Console.ReadLine();
        Console.Write("Enter company manager age: ");
        int companyManagerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter company manager phone number: ");
        string companyManagerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Adress: {0}", companyAdress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        if (companyFaxNumber == "")
        {
            Console.WriteLine("(no fax)");
        }
        else
        {
            Console.WriteLine(companyFaxNumber);
        }
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.Write("Manage: {0} {1}", companyManagerName, companyManagerLastName);
        Console.Write(" (age: {0}, tel. {1} )", companyManagerAge, companyManagerPhone);
    }
}
//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

