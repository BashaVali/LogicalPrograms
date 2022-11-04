using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        TimeSpan timeSpan = TimeSpan.Zero;
        public void Start()
        {
            int startHr = timeSpan.Hours;
            int startMin = timeSpan.Minutes;
            int StartSec = timeSpan.Seconds;
            int startMilliSec = timeSpan.Milliseconds;
            Console.WriteLine("Press s to start");
            string data = Console.ReadLine().ToLower();
            if (data.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine("press x for exit");
                string stop = Console.ReadLine().ToLower();
                if (stop.Equals("s"))
                {
                    DateTime dateTime1 = DateTime.Now;
                    Console.WriteLine(dateTime1.Millisecond);
                    int stopHr = dateTime1.Hour;
                    int stopMin = dateTime1.Minute;
                    int stopSec = dateTime1.Second;
                    int stopMilliSec = dateTime1.Millisecond;
                    Console.WriteLine("StopWatch details:- Hours:" + (stopHr - startHr)
                        + "Minutes:" + (stopMin - startMin) + "Seconds" + (stopSec - stopSec) +
                       "Milliseconds:" + (stopMilliSec - stopMilliSec));
                }
            }
        }
    }
}