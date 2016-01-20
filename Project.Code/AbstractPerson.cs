

namespace Project.Code.AbstractPerson
{
    internal abstract class Person
    {
        internal abstract long studentId { get; set; }
        internal abstract string studentFirstName { get; set; }
        internal abstract string studentLastName { get; set; }
        internal abstract float studentGpa { get; set; }
    }
}
