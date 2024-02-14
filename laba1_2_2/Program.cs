using System;
using System.Threading;

namespace laba1_2_2
{
    public class Timer
    {
        private Action action;
        private int interval;
        private bool isRunning;
        private Thread thread;

        public Timer(Action action, int seconds)
        {
            this.action = action;
            this.interval = seconds * 1000;
        }

        public void Start()
        {
            if (!this.isRunning)
            {
                this.isRunning = true;
                this.thread = new Thread(Run);
                this.thread.Start();
            }
        }

        public void Stop()
        {
            this.isRunning = false;
            if (this.thread != null && this.thread.IsAlive)
            {
                this.thread.Join();
            }
        }

        private void Run()
        {
            while (this.isRunning)
            {
                this.action.Invoke();
                Thread.Sleep(this.interval);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Timer timer1 = new Timer(() => Console.WriteLine("Timer 1 executed"), 3);
            Timer timer2 = new Timer(() => Console.WriteLine("Timer 2 executed"), 9);

            timer1.Start();
            timer2.Start();
            
            Thread.Sleep(10000);

            timer1.Stop();
            timer2.Stop();

            Console.WriteLine("Timers stopped");
        }
    }
}
