using System;
using Project.Code;
using Project.Code.DataValidiation;

class Program
{
    static void Main()
    {
        StudentContainer.InitializeList();
        ConsoleInput();
    }

    static void ConsoleInput()
    {
        Console.WriteLine("Operation:");
        string operationInput = Console.ReadLine();
        while (Validiation.CheckOperation(operationInput) == "false")
        {
            Console.WriteLine("Operation non-existing, please use appropriate operation.\nOperation:");
            operationInput = Console.ReadLine();
        }
        if (Validiation.CheckOperation(operationInput) == "display")
        {
            Display();
        }
        if (Validiation.CheckOperation(operationInput) == "enlist")
        {
            Enlist();
        }
    }

    static void Display()
    {
        StudentContainer.StudentRead();
    }

    static void Enlist()
    {
        Console.WriteLine("Student\nFirst name:");
        string firstNameInput = Console.ReadLine();
        while (Validiation.CheckIfNull(firstNameInput) == true)
        {
            Console.WriteLine("You need to insert value.\nFirst name:");
            firstNameInput = Console.ReadLine();
        }
        Console.WriteLine("Last name:");
        string lastNameInput = Console.ReadLine();
        while (Validiation.CheckIfNull(lastNameInput) == true)
        {
            Console.WriteLine("You need to insert value.\nFirst name:");
            lastNameInput = Console.ReadLine();
        }
        Console.WriteLine("GPA:");
        string gpaInput = Console.ReadLine();
        float gpaFloat;
        while (!float.TryParse(gpaInput, out gpaFloat) || Validiation.CheckIfNull(gpaInput) == true)
        {
            Console.WriteLine("Invalid value\nGPA:");
            gpaInput = Console.ReadLine();
        }
        StudentContainer.StudentData(firstNameInput, lastNameInput,gpaFloat);
         ConsoleInput();
    }
}