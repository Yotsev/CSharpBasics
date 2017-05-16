using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            var startHour = Console.ReadLine();
            var startMin = Console.ReadLine();
            var start = startHour + ":" + startMin;
            var arrivelHour = Console.ReadLine();
            var arrivelMin = Console.ReadLine();
            var arrivel = arrivelHour + ":" + arrivelMin;
            var examStart = DateTime.ParseExact(start, "H:m", null);
            var arrivelTime = DateTime.ParseExact(arrivel, "H:m", null);
            var differemce = arrivelTime - examStart;
            if (differemce > TimeSpan.Zero)
            {
                Console.WriteLine("Late");
            }
            else if (differemce >= new TimeSpan(0, -30, 0) && differemce <= TimeSpan.Zero)
            {
                Console.WriteLine("On Time");
                if (differemce == TimeSpan.Zero)
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("Early");
            }
            var modifier = (differemce <= TimeSpan.Zero ? "before" : "after");
            if (differemce.Hours == 0)
            {
                Console.WriteLine("{0} minutes {1:D2} the start",Math.Abs(differemce.Minutes),modifier);
            }
            else
            {
                Console.WriteLine("{0}:{1:D2} hours {2} the start", Math.Abs(differemce.Hours),Math.Abs(differemce.Minutes),modifier);
            }
        }
    }
}
