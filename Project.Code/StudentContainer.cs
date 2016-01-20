using System;
using System.Collections.Generic;
using Project.Code.StudentData;
using Project.Code.IdGenerator;

namespace Project.Code
{
     public class StudentContainer
    {
        static List<Student> studentList;
        public static void InitializeList()
        {
            studentList = new List<Student>();
        }
        public static void StudentData(string firstName, string lastName, float gpa)
        {
            Student s = new Student();
            s.studentFirstName = firstName;
            s.studentLastName = lastName;
            s.studentGpa = gpa;
            s.studentId = CreateStudentIdGenerator.Instance.getNextID();
            studentList.Add(s);
        }
        public static void StudentRead()
        {
            Console.WriteLine("Students in a system:");
            foreach (Student s in studentList)
            {
                Console.WriteLine("{0}. {1}, {2} - {3}", s.studentId, s.studentLastName, s.studentFirstName, s.studentGpa);
            }
            Console.ReadKey(true);
        }
    }
}