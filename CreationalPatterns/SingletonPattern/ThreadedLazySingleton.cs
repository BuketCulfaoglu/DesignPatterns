namespace SingletonPattern
{
    internal class ThreadedLazySingleton : Singleton
    {
        private static ThreadedLazySingleton _instance;
        private static int _count;

        private ThreadedLazySingleton()
         {
            _count++;
            _name = "ThreadedLazySingleton" + _count;
        }

        public static ThreadedLazySingleton GetInstance()
        {
            if (_instance == null)
                _instance = new ThreadedLazySingleton();

            return _instance;
        }
    }
}
