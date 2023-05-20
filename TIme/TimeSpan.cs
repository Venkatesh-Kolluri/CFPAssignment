using System.Diagnostics;

namespace Time
{
    internal class TimeSpan
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Hello, World!");
            System.Threading.Thread.Sleep(2000);
            sw.Stop();
            System.TimeSpan elapsed = sw.Elapsed;
            Console.WriteLine("Execution Time: "+elapsed);
        }
    }
}