using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public  class Duration
    {
       private int Hours { get; set; }
       private int Minutes { get; set; }
       private int Seconds { get; set; }
       public int TotalSeconds { get; set; }
        public override string ToString()
        {
            return $"Hours:= {Hours}, Minutes: {Minutes}, Second: {Seconds}";
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            ConvertClockToTotalSec(hours, minutes, seconds);
        }
        public Duration(int totalSeconds)
        {
            TotalSeconds = totalSeconds;
            ConvertTotalSecsToMinsAndSecs(totalSeconds);
            ConvertFromMinsToHrAndMin(Minutes);

        }
        private void ConvertTotalSecsToMinsAndSecs(int totalSec)
        {

            if(totalSec <= 60 && totalSec >0  )
            {
                Minutes = 0;
                Seconds = totalSec;
            }
            else
            {
                Minutes = totalSec / 60;
                Seconds = totalSec % 60;             
            }
        }
        private void ConvertFromMinsToHrAndMin(int totalMins=0)
        {
            if(Minutes ==0)         
                Hours = 0;
            else
            {
                Hours = totalMins / 60;
                 Minutes= totalMins % 60;
            }
            
        }
        private void ConvertClockToTotalSec(int hours, int minutes, int seconds)=>
              TotalSeconds = seconds + (minutes * 60) + (hours * 3600);
        public static Duration operator +(Duration duration1,Duration duration2)=>
             new Duration(duration1.TotalSeconds + duration2.TotalSeconds);
        public static Duration operator +(Duration duration, int totalSecs) =>
             new Duration(duration.TotalSeconds + totalSecs);
        public static Duration operator +( int totalSecs, Duration duration) =>
             new Duration(duration.TotalSeconds + totalSecs);
        public static Duration operator ++(Duration duration) =>
            new Duration(duration.TotalSeconds + 60);
        public static Duration operator --(Duration duration)=> 
            new Duration(duration.TotalSeconds-60);
        public static bool operator <(Duration duration1,Duration duration2)=> 
            duration1.TotalSeconds < duration2.TotalSeconds;
        public static bool operator >(Duration duration1, Duration duration2)=>
            duration1.TotalSeconds > duration2.TotalSeconds;
        public static bool operator <=(Duration duration1, Duration duration2) =>
             duration1.TotalSeconds <= duration2.TotalSeconds;
        public static bool operator >=(Duration duration1, Duration duration2) =>
            duration1.TotalSeconds >= duration2.TotalSeconds;

        /// <summary>
        /// boolean casting
        /// </summary>
        /// <param name="duration"></param>
        public static implicit operator bool(Duration duration) => duration.TotalSeconds > 0;





    }
}
