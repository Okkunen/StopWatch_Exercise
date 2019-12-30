using System;
namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning = false;

        public StopWatch()
        {

        }

        public void Start()
        {
            if (_isRunning == false)
            {
                _startTime = DateTime.UtcNow;
                _isRunning = true;
                Console.WriteLine("Stopwatch was started at {0}", _startTime);
            }
            else
            {
                Console.WriteLine("Stopwatch is already running.");
            }
            
        }

        public void Stop()
        {
            if (_isRunning == true)
            {
                _stopTime = DateTime.UtcNow;
                _isRunning = false;
                TimeSpan runTime = _stopTime - _startTime;
                Console.WriteLine("Stopwatch has been stopped. Stopwatch ran for {0}", runTime);
            }
            else
            {
                Console.WriteLine("Stopwatch is not running");
            }
        }

    }
}
