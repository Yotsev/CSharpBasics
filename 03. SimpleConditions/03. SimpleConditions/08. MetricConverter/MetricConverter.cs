using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount: ");
            var amount = double.Parse(Console.ReadLine());
            Console.Write("Enter Input units: ");
            string inputUnit = Console.ReadLine();
            Console.Write("Enter Output units: ");
            string outoptUnit = Console.ReadLine();
            var factor = 0.0;
            if (inputUnit == "m")
            {
                factor = 1;
            }
            else if (inputUnit == "mm")
            {
                factor = 1 / 1000;
            }
            else if (inputUnit == "cm")
            {
                factor = 1 / 100;
            }
            else if (inputUnit == "mi")
            {
                factor = 1 / 1.000621371192;
            }
            else if (inputUnit == "in")
            {
                factor = 1 / 39.3700787;
            }
            else if (inputUnit == "km")
            {
                factor = 1 / 0.001;
            }
            else if (inputUnit == "ft")
            {
                factor = 1 / 3.2808399;
            }
            else if (inputUnit == "yd")
            {
                factor = 1 / 1.0936133;
            }

            var inMeters = amount * factor; // Преобразуваме числото в метри

            if (outoptUnit == "m")
            {
                factor = 1;
            }
            else if (outoptUnit == "mm")
            {
                factor = 1000;
            }
            else if (outoptUnit == "cm")
            {
                factor = 100;
            }
            else if (outoptUnit == "mi")
            {
                factor = 1.000621371192;
            }
            else if (outoptUnit == "in")
            {
                factor = 39.3700787;
            }
            else if (outoptUnit == "km")
            {
                factor = 0.001;
            }
            else if (outoptUnit == "ft")
            {
                factor = 3.2808399;
            }
            else if (outoptUnit == "yd")
            {
                factor = 1.0936133;
            }
            Console.WriteLine(inMeters * factor + " " + outoptUnit); // Обръщаме от метри в желаното число и изписваме мерната единица
        }
    }
}
