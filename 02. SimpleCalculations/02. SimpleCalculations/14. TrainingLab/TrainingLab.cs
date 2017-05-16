using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            var length = double.Parse(Console.ReadLine()) * 100;
            Console.Write("Enter with width: ");
            var width = double.Parse(Console.ReadLine()) * 100 - 100;
            var totalSeats = Math.Floor (length/120) * Math.Floor (width/70);
            Console.WriteLine("Total Seats in the room are:{0} ", totalSeats -3 );
        }
    }
}
