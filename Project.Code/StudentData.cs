namespace Project.Code.StudentData
{
    internal class Student : AbstractPerson.Person
    {
        internal override string studentFirstName { get; set; }
        internal override float studentGpa { get; set; }
        internal override string studentLastName { get; set; }
        internal override long studentId { get; set; }
    }
}
