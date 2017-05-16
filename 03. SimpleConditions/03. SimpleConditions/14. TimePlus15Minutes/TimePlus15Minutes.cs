using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hours: ");
            var hours = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            var minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
                if (hours >=24)
                {
                    hours -= 24;
                }
            }
            Console.WriteLine("{0}:{01:00}", hours, minutes);
        }
    }
}
