using System;
using DalApi;
using DO;

namespace DalTest;

internal class Program
{
    private static IDal s_dal = new Dal.DalList();

    static void Main(string[] args)
    {
        try
        {
            Initialization.Initialize(s_dal);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Test Entity (מבחנים)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            TestMenu(); 
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private static void TestMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Test CRUD Menu ---");
            Console.WriteLine("1. Create (הוספה)");
            Console.WriteLine("2. Read (קריאה לפי ת.ז)");
            Console.WriteLine("3. ReadAll (קריאת כל המבחנים)");
            Console.WriteLine("4. Update (עדכון)");
            Console.WriteLine("5. Delete (מחיקה)");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                try
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            AddTest();
                            break;
                        case 2:
                            ReadTest();
                            break;
                        case 3:
                            ReadAllTests();
                            break;
                        case 4:
                            UpdateTest();
                            break;
                        case 5:
                            DeleteTest();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }


    private static void AddTest()
    {
        Console.Write("Enter Subject ID (מספר נושא): ");
        int subject = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Number of Questions (כמות שאלות): ");
        int numQs = int.Parse(Console.ReadLine() ?? "0");

        Test newTest = new Test(0, subject, DateTime.Now, numQs);
        int newId = s_dal.Test.Create(newTest);
        Console.WriteLine($"Test created successfully! The new ID is: {newId}");
    }

    private static void ReadTest()
    {
        Console.Write("Enter Test ID to read: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Test? t = s_dal.Test.Read(id);
        if (t != null)
            Console.WriteLine(t); 
        else
            Console.WriteLine("Test not found.");
    }

    private static void ReadAllTests()
    {
        var tests = s_dal.Test.ReadAll();
        foreach (var t in tests)
        {
            Console.WriteLine(t);
        }
    }

    private static void UpdateTest()
    {
        Console.Write("Enter Test ID to update: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Subject ID: ");
        int subject = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Number of Questions: ");
        int numQs = int.Parse(Console.ReadLine() ?? "0");

        Test updatedTest = new Test(id, subject, DateTime.Now, numQs);
        s_dal.Test.Update(updatedTest);
        Console.WriteLine("Test updated successfully.");
    }

    private static void DeleteTest()
    {
        Console.Write("Enter Test ID to delete: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        s_dal.Test.Delete(id);
        Console.WriteLine("Test deleted successfully.");
    }
}