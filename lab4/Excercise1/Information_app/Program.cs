using System;

class Program
{
    static void Main()
    {
        string name, address, phone;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your address: ");
        address = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        phone = Console.ReadLine();

        Console.WriteLine("\nYour Information:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Phone Number: " + phone);

    }
}
