using System;
using Project.Code;

class Program
{
    static void Main()
    {
        studentContainer.initializeList();
        consoleInput();
    }

    static void consoleInput()
    {
        Console.WriteLine("Operation:");
        string operationInput = Console.ReadLine();
        while (validiation.checkOperation(operationInput) == "false")
        {
            Console.WriteLine("Operation non-existing, please use appropriate operation.\nOperation:");
            operationInput = Console.ReadLine();
        }
        if (validiation.checkOperation(operationInput) == "display")
        {
            display();
        }
        if (validiation.checkOperation(operationInput) == "enlist")
        {
            enlist();
        }
    }

    static void display()
    {
        studentContainer.studentRead();
    }

    static void enlist()
    {
        Console.WriteLine("Student\nFirst name:");
        string firstNameInput = Console.ReadLine();
        while (validiation.checkIfNull(firstNameInput) == true)
        {
            Console.WriteLine("You need to insert value.\nFirst name:");
            firstNameInput = Console.ReadLine();
        }
        Console.WriteLine("Last name:");
        string lastNameInput = Console.ReadLine();
        while (validiation.checkIfNull(lastNameInput) == true)
        {
            Console.WriteLine("You need to insert value.\nFirst name:");
            lastNameInput = Console.ReadLine();
        }
        Console.WriteLine("GPA:");
        string GPAInput = Console.ReadLine();
        float GPAfloat;
        while (!float.TryParse(GPAInput, out GPAfloat) || validiation.checkIfNull(GPAInput) == true)
        {
            Console.WriteLine("Invalid value\nGPA:");
            GPAInput = Console.ReadLine();
        }
        studentContainer.studentData(firstNameInput, lastNameInput,GPAfloat);
         consoleInput();
    }
}