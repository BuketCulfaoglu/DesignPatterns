namespace SingletonPattern
{
    internal class BasicSingleton : Singleton
    {
        private static BasicSingleton _instance = new BasicSingleton();
        private static int _count;

        private BasicSingleton()
        {
            _count++;
            _name = "BasicSingleton" + _count;
        }

        public static BasicSingleton GetInstance()
        {
            return _instance;
        }

    }
}
