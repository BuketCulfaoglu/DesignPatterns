using SingletonPattern;

////BasicSingleton
//for (int i = 0; i < 10; i++)
//{
//    BasicSingleton bs = BasicSingleton.GetInstance();
//    bs.PrintName();
//}

////LazySingleton
//for (int i = 0; i < 10; i++)
//{
//    LazySingleton ls = LazySingleton.GetInstance();
//    ls.PrintName();
//}


//ThreadedLazySingleton
//for (int i = 0; i < 10; i++)
//{
//    Thread thread = new Thread(() =>
//    {
//        ThreadedLazySingleton tls = ThreadedLazySingleton.GetInstance();
//        tls.PrintName();
//    });
//}

Thread[] threads = new Thread[200];
for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(() =>
    {
        ThreadedLazySingleton instance = ThreadedLazySingleton.GetInstance();
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} - Name: {instance.GetName()} - Instance hash code: {instance.GetHashCode()}");
    });
    threads[i].Start();
}

// Join all threads to ensure they complete before the main thread proceeds
foreach (var thread in threads)
{
    thread.Join();
}
