using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TomTheSleepyCat
{
    class TomTheSleepyCat
    {
        static void Main(string[] args)
        {
            var holydays = int.Parse(Console.ReadLine());
            int warkdays = 365 - holydays;
            int minutes = holydays * 127 + warkdays * 63;
            int diff =Math.Abs (minutes - 30000);
            int hours = diff / 60;
            int mins = diff % 60;
            if (minutes < 300000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",hours, mins);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);

            }
        }
    }
}
