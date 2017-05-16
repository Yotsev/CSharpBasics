using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            var examHours = int.Parse(Console.ReadLine());
            var examMinues = int.Parse(Console.ReadLine());
            var studentHours = int.Parse(Console.ReadLine());
            var studentMinutes = int.Parse(Console.ReadLine());

            var examTime = examHours * 60 + examMinues;
            var studentTime = studentHours * 60 + studentMinutes;
            var minutesDifference = studentTime - examTime;

            if (minutesDifference < -30)
                Console.WriteLine("Early");
            else if (minutesDifference <= 0)
                Console.WriteLine("On Time");
            else
                Console.WriteLine("Late");

            if (minutesDifference != 0)
            {
                var hours = Math.Abs(minutesDifference / 60);
                var minutes = Math.Abs(minutesDifference % 60);
                if (hours > 0)
                {
                    if(minutes<10)
                        Console.WriteLine(hours + ":0" + minutes + " hours");
                    else
                        Console.WriteLine(hours + ":"+ minutes+" hours");
                }
                else
                    Console.WriteLine(minutes + " minutes");
                if(minutesDifference<0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");
            }
        }
    }
}
