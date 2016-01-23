namespace Project.Code
{
    public sealed class IdGenerator
    {
        private long currentId = 0;
        private static IdGenerator instance = null;
        public static IdGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new IdGenerator();
                }
                return instance;
            }
        }
        public long GetNextID()
        {
            currentId++;
            return currentId;
        }
    }
}