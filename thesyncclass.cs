using System;
using System.Threading.Tasks;
using System.IO;


namespace a_sync_test
{
    public class doingAsync
    {
        public static async Task<int> dosomething1(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously
                // and returns them as one string.
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }

        public static async void TehRead()
        {
            string filePath = "/home/kellyj/temp/thedir.txt";
            Task<int> task = dosomething1(filePath);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int length = await task;
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");

        }

        public void  dosomething2()
        {


            for (int x=0;x<40;x++)
            {
                Console.WriteLine("XX "+x.ToString());
                Task.Delay(100).Wait();
            }

        }

        public doingAsync()
        {
            Console.WriteLine("Hello Nurse");
        }
    }
}