

namespace Project.Code.IdGenerator
{
    public sealed class CreateStudentIdGenerator
    {
        public long currentId = 0;
        private static CreateStudentIdGenerator instance = null;
        public static CreateStudentIdGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateStudentIdGenerator();
                }
                return instance;
            }
        }
        public long getNextID()
        {
            currentId++;
            return currentId;
        }
    }
}
