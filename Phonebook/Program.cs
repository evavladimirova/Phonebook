using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

class Phonebook
{
    static Dictionary<string, string> contacts = new Dictionary<string, string>();

    static void Main()
    {
        Boolean ProgramRunning = true;
        while (ProgramRunning)
        {
            Console.WriteLine("Phonebook Menu:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display the whole phonebook");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    addContact();
                }
                if (choice == 2)
                {
                    SearchContact();
                }
                if (choice == 3)
                {

                    DeleteContact();
                }

                if (choice == 5)
                {
                    ProgramRunning = false;
                }
                if (choice == 4)
                {
                    Display();
                }
                if (choice > 5)
                {
                    Console.WriteLine("Enter a valid choice number");

                }

            }

        }
    }

    public static void addContact()
    {
        Console.Write("Enter the name of the contact: ");
        string name = Console.ReadLine();
        Console.Write("Enter the phone number: ");
        string phoneNumber = Console.ReadLine();

        if (!contacts.ContainsKey(name))
        {
            contacts[name] = phoneNumber;
            Console.WriteLine("Contact added successfully.");
        }
        else
        {
            Console.WriteLine("Contact already exists. Use the update option to modify the contact.");
        }
    }

    public static void SearchContact()
    {
        Console.Write("Enter the name to search: ");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Console.WriteLine($"Name: {name}, Phone Number: {contacts[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }

    }

    public static void DeleteContact()
    {
        Console.Write("Enter the name to delete: ");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            contacts.Remove(name);
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public static void Display()
    {
        Console.WriteLine();

        Console.WriteLine("The glorious phonebook");
        Console.WriteLine();
        foreach (var kvp in contacts)
        {

            Console.WriteLine("Name: " + kvp.Key + " Number: " + kvp.Value);
        }
    }
}


