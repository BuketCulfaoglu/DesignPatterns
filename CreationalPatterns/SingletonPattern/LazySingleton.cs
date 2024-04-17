namespace SingletonPattern
{
    internal class LazySingleton : Singleton
    {
        private static LazySingleton _instance;
        private static int _count;

        private LazySingleton()
        {
            _count++;
            _name = "LazySingleton" + _count;
        }

        public static LazySingleton GetInstance()
        {
            if (_instance == null)
                _instance = new LazySingleton();

            return _instance;
        }
    }
}
