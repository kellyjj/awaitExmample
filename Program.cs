using System;
using System.Threading.Tasks;


namespace a_sync_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            doingAsync a = new doingAsync();

            Task task = new Task(doingAsync.TehRead);


            task.Start();
            task.Wait();

            Console.ReadLine();
        }
    }
}
