using System;

namespace DockerConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            while (max == -1 || counter < max)
            {
                counter++;
                Console.WriteLine($"Counter: {counter}");
                System.Threading.Tasks.Task.Delay(1000).Wait();
            }
        }
    }
}
