using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch clock = new StopWatch();

            clock.Start();
            clock.Start();
            System.Threading.Thread.Sleep(5000);
            clock.Stop();
            clock.Stop();
            clock.Start();
            System.Threading.Thread.Sleep(3000);
            clock.Stop();
            Console.ReadLine();
        }
    }
}
