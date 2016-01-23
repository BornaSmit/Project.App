using System.Collections.Generic;

namespace Project.Code
{
     public class StudentContainer
    {
        public static List<Student> studentList;
        public static void Initialize()
        {
            studentList = new List<Student>();
        }
        public static void AddStudentData(string firstName, string lastName, float gpa)
        {
            Student s = new Student();
            s.firstName = firstName;
            s.lastName = lastName;
            s.studentGpa = gpa;
            s.id = IdGenerator.Instance.GetNextID();
            studentList.Add(s);
        }
    }
}