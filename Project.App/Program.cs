using System;
using Project.Code;

class Program
{
    static void Main()
    {
        StudentContainer.Initialize();
        ConsoleInput();
    }

    static void ConsoleInput()
    {
        Console.WriteLine("Operation:");
        string operationInput = Console.ReadLine();
        if (operationInput.Equals(Operations.enlist, StringComparison.CurrentCultureIgnoreCase))
        {
            Enlist();
        }
        else if (operationInput.Equals(Operations.display, StringComparison.CurrentCultureIgnoreCase))
        {
            Display();
        }
        else
        {
            Console.WriteLine("Operation non-existing, please use appropriate operation.");
            ConsoleInput();
        }
    }

    static void Display()
    {
        Console.WriteLine("Students in a system:");
        foreach (Student s in StudentContainer.ReadStudentData())
        {
            Console.WriteLine("{0}. {1}, {2} - {3}", s.Id, s.LastName, s.FirstName, s.Gpa);
        }
        Console.ReadKey(true);
    }

    static void Enlist()
    {
        Console.WriteLine("Student\nFirst name:");
        string firstNameInput = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(firstNameInput))
        {
            Console.WriteLine("You need to insert value.\nFirst name:");
            firstNameInput = Console.ReadLine();
        }
        Console.WriteLine("Last name:");
        string lastNameInput = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(lastNameInput))
        {
            Console.WriteLine("You need to insert value.\nFirst name:");
            lastNameInput = Console.ReadLine();
        }
        Console.WriteLine("GPA:");
        string gpaInput = Console.ReadLine();
        float gpaFloat;
        while (!float.TryParse(gpaInput, out gpaFloat) || string.IsNullOrWhiteSpace(gpaInput))
        {
            Console.WriteLine("Invalid value\nGPA:");
            gpaInput = Console.ReadLine();
        }
        StudentContainer.AddStudentData(firstNameInput, lastNameInput,gpaFloat);
         ConsoleInput();
    }
}