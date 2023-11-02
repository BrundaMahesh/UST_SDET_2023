Thread thread1 = new Thread(T1);
Thread thread2 = new Thread(T1);

// Start the threads
thread1.Start();
thread2.Start();

// Wait for the threads to finish
thread1.Join();
thread2.Join();

Console.WriteLine("Both threads have completed their work.");

static void T1()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
        Thread.Sleep(100); // Simulate some work
    }
}