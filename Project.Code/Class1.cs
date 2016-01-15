using System;
using System.Collections.Generic;

namespace Project.Code
{
    public static class Operations
    {
        public static string display = "DISPLAY";
        public static string enlist = "ENLIST";
    }

    public abstract class Person
    {
        public abstract long studentID {get; set;}
        public abstract string studentFirstName { get; set; }
        public abstract string studentLastName { get; set; }
        public abstract float studentGPA { get; set; }
    }

    public class Student : Person
    {
        public override string studentFirstName { get; set; }
        public override float studentGPA { get; set; }
        public override string studentLastName { get; set; }
        public override long studentID{ get; set; }
    }

    public class studentContainer
    {
        static List<Student> studentList;
        public static void initializeList()
        {
            studentList = new List<Student>();
        }
        public static void studentData(string name, string lastname, float GPA)
        {
            Student s = new Student();
            s.studentFirstName = name;
            s.studentLastName = lastname;
            s.studentGPA = GPA;
            s.studentID = createStudentIdGenerator.Instance.getNextID();
            studentList.Add(s);
        }
        public static void studentRead()
        {
            Console.WriteLine("Students in a system:");
            foreach (Student s in studentList)
            {
                Console.WriteLine("{0}. {1}, {2} - {3}", s.studentID, s.studentLastName, s.studentFirstName, s.studentGPA);
            }
            Console.ReadKey(true);
        }
    }

    public class validiation
    {
        public static bool checkIfNull(string a)
        {
            if (string.IsNullOrWhiteSpace(a))
            {
                return true;
            }
            else { return false; }
        }

        public static string checkOperation(string a)
        {
            if (a.Equals(Operations.display, StringComparison.CurrentCultureIgnoreCase))
            {
                return "display";
            }
            else if (a.Equals(Operations.enlist, StringComparison.CurrentCultureIgnoreCase))
            {
                return "enlist";
            }
            else return "false"; 
        }
    }

    public sealed class createStudentIdGenerator
    {
        public long currentID = 0;
        private static createStudentIdGenerator instance = null;
        public static createStudentIdGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new createStudentIdGenerator();
                }
                return instance;
            }
        }
        public long getNextID()
        {
            currentID++;
            return currentID;
        }
     }
}
