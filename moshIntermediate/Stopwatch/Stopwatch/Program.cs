using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private int Start;
        public int Stop;

        public void SetStop(int stop)
        {
            Stop = stop;
        }

        public void Duration()
        {
            int duration = Stop - Start;

            Start = Stop;
            Console.WriteLine(duration);
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.SetStop(5);
            stopwatch.Duration();


            stopwatch.SetStop(15);
            stopwatch.Duration();

            stopwatch.SetStop(30);
            stopwatch.Duration();
        }
    }
}
