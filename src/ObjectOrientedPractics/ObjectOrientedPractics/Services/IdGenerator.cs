namespace ObjectOrientedPractics.Services
{
    public class IdGenerator
    {
        private static int _id = -1;
        public static int GetNextId()
        {
            _id++;
            return _id;
        }
    }
}
