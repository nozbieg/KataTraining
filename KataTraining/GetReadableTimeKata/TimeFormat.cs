using System;
using System.Linq;

namespace KataTraining.GetReadableTimeKata
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            var ts = TimeSpan.FromSeconds(seconds);

            return $"{(int)ts.TotalHours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}";
        }
    }
}

