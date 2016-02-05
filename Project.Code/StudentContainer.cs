using System;
using System.Collections.Generic;

namespace Project.Code
{
    public class StudentContainer
    {
        private static List<Student> studentList;
        private static List<Student> sortedList;
        public static void Initialize()
        {
            studentList = new List<Student>();
        }
        public static void AddStudentData(string firstName, string lastName, float gpa)
        {
            Student s = new Student();
            s.FirstName = firstName;
            s.LastName = lastName;
            s.Gpa = gpa;
            s.Id = IdGenerator.Instance.GetNextID();
            studentList.Add(s);
        }

        public static List<Student> ReadStudentData()
        {
            sortedList = studentList;
            sortedList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            return sortedList;          
        }
    }
}
