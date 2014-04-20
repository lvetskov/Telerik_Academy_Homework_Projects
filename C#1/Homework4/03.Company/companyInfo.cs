using System;

namespace _03.Company
{
    class companyInfo
    {
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

        static void Main()
        {
            Console.Write("Write down company's name:");
            string companyName = Console.ReadLine();
            Console.Write("Write down company's address:");
            string companyAddress = Console.ReadLine();
            Console.Write("Write down company's phone number:");
            string companyPhoneNum = Console.ReadLine();
            Console.Write("Write down company's fax number:");
            string companyFaxNum = Console.ReadLine();
            Console.Write("Write down company's web site:");
            string companyWeb = Console.ReadLine();
            Console.Write("Write down manager's first name:");
            string manager1Name = Console.ReadLine();
            Console.Write("Write down manager's last name:");
            string managerLastName = Console.ReadLine();
            Console.Write("Write down manager's age:");
            string managerAge = Console.ReadLine();
            Console.Write("Write down manager's phone number:");
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Company's name: {0}", companyName);
            Console.WriteLine("Company's address: {0}", companyAddress);
            Console.WriteLine("Company's phone number: {0}", companyPhoneNum);
            Console.WriteLine("Company's fax number: {0}", companyFaxNum);
            Console.WriteLine("Company's web site: {0}", companyWeb);
            Console.WriteLine("Manager's first name: {0}", manager1Name);
            Console.WriteLine("Manager's last name: {0}", managerLastName);
            Console.WriteLine("Manager's age: {0}", managerAge);
            Console.WriteLine("Manager's phone number: {0}", managerPhoneNumber);

        }
    }
}
