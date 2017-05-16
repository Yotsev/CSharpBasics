using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int initialSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double firstTimeHours = firstTime / 60.0;
            double secondTimeHours = secondTime / 60.0;
            double thirdTimeHours = thirdTime / 60.0;

            double distenceAfterFirstTime = initialSpeed * firstTimeHours;
            double speedAfterAceleration = initialSpeed + initialSpeed * 0.1;
            double distenceAfterSecondTime = speedAfterAceleration * secondTimeHours;
            double speedAfterDeceleration = speedAfterAceleration - speedAfterAceleration * 0.05;
            double distenceAfterThirdTime = speedAfterDeceleration * thirdTimeHours;

            double totalDistence = distenceAfterFirstTime + distenceAfterSecondTime + distenceAfterThirdTime;



            Console.WriteLine("{0:f2}",totalDistence);
        }
    }
}
