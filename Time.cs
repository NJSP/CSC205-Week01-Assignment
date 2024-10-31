using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class Time
    {
        public int hour, minute;
        public double second;
        
        public Time(int Hour, int Minute, double Second)
        {
            this.hour = Hour;
            this.minute = Minute;
            this.second = Second;
        }
        // Methods-----------------------------------
        public void DisplayTime()
        {
            Console.WriteLine($"{this.hour}:{this.minute}:{this.second}");
        }
        public void TimeSince()
        {
            double time_since = (this.hour * 3600) + (this.minute * 60) + this.second;
            Console.WriteLine($"Seconds since midnight: {time_since}");
        }
        public void TimeLeft()
        {
            double time_left = (24 * 3600) - ((this.hour * 3600) + (this.minute * 60) + this.second);
            Console.WriteLine($"Seconds remaining in the day: {time_left}");
        }
        public void TimePercent()
        {
            double time_percent = ((this.hour * 3600) + (this.minute * 60) + this.second) / (24 * 3600);
            Console.WriteLine($"Percentage of the day that has passed: {time_percent}");
        }
    }
}