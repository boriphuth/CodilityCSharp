using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class T5
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            // input = @"Sun 10:00-20:00 \n Mon 09:10-09:30";
            int result = Solution(input);
            Console.WriteLine(string.Join(" ", result));
        }

        public static int Solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            // var days = new List<string> {"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};

            var daysArray = Enum.GetValues(typeof(Days));

            var mlineList = S.Split(@" \n ");
            var MlineList = new List<Mline>();

            foreach (var mline in mlineList)
            {
                var dateSplit = mline.Split(' ');
                var Ddd = dateSplit[0];
                foreach (int enumValue in daysArray)
                {
                    if (Enum.GetName(typeof(Days), enumValue) == Ddd)
                    {
                        Ddd = enumValue.ToString();
                        break;
                    }
                }

                var timeSplit = dateSplit[1].Split('-');

                var TimeStartSplit = timeSplit[0].Split(':');
                var TimeStarthh = TimeStartSplit[0];
                var TimeStartmm = TimeStartSplit[1];

                // Use TimeSpan constructor to specify:
                // ... Days, hours, minutes, seconds, milliseconds.
                // ... The TimeSpan returned has those values.
                //TimeSpan span = new TimeSpan(1, 2, 0, 30, 0);
                var TimeStoptSplit = timeSplit[1].Split(':');
                var TimeStophh = TimeStoptSplit[0];
                var TimeStopmm = TimeStoptSplit[1];
                var TimeStart = new TimeSpan(Convert.ToInt32(Ddd), Convert.ToInt32(TimeStarthh), Convert.ToInt32(TimeStartmm), 0);
                var TimeStop = new TimeSpan(Convert.ToInt32(Ddd), Convert.ToInt32(TimeStophh), Convert.ToInt32(TimeStopmm), 0);
                var TimeDiff = TimeStop.Subtract(TimeStart);

                MlineList.Add(new Mline
                {
                    Ddd = Ddd,
                    TimeStarthh = TimeStarthh,
                    TimeStartmm = TimeStartmm,
                    TimeStophh = TimeStophh,
                    TimeStopmm = TimeStopmm,
                    TimeStart = TimeStart,
                    TimeStop = TimeStop,
                    TimeDiff = TimeDiff
                });
            }
            int result = 0;

            foreach (var mline in MlineList)
            {
                var TimeDiffResult = new TimeSpan(Convert.ToInt32(mline.Ddd), 0, 0, 0, 0);
                result = TimeSpan.Compare(TimeDiffResult, mline.TimeDiff);
                if (result == -1)
                {
                    TimeDiffResult = mline.TimeDiff;
                    result = Convert.ToInt32(mline.Ddd);
                }
            }
            return result;
        }
    }
    enum Days
    {
        Mon = 1, Tue = 2, Wed = 3, Thu = 4, Fri = 5, Sat = 6, Sun = 7
    }

    public class Mline
    {
        public string Ddd { get; set; }
        public TimeSpan TimeDiff { get; set; }
        public string TimeStarthh { get; set; }
        public string TimeStartmm { get; set; }
        public string TimeStophh { get; set; }
        public string TimeStopmm { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeStop { get; set; }
    }
}
