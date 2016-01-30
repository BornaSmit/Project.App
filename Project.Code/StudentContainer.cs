using System;
using System.Collections.Generic;

namespace Project.Code
{
     public class StudentContainer
    {
        private static List<Student> studentList;
        public static void Initialize()
        {
            studentList = new List<Student>();
        }
        public static void AddStudentData(string firstName, string lastName, float gpa)
        {
            Student s = new Student();
            s.firstName = firstName;
            s.lastName = lastName;
            s.gpa = gpa;
            s.id = IdGenerator.Instance.GetNextID();
            studentList.Add(s);
        }
        public static void GetStudentData()
        {
            foreach (Student s in studentList)
            {
                Console.WriteLine("{0}. {1}, {2} - {3}", s.id, s.lastName, s.firstName, s.gpa);
            }
        }
    }
}