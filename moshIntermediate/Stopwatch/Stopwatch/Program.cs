using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        public int Start;
        public int Stop;

        public void SetStart(int start)
        {
            Start = start;
        }

        public void SetStop(int stop)
        {
            Stop = stop;
        }

        public int Duration()
        {
            int duration = Stop - Start;
            return duration;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.SetStart(3);
            stopwatch.SetStop(5);

            Console.WriteLine(stopwatch.Duration());
        }
    }
}
