using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            Console.Write("Enter figur: ");
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                Console.Write("Enter side a= ");
                var a = double.Parse(Console.ReadLine());
                var area = a * a;
                Console.WriteLine("{0}", Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                Console.Write("Enter side a= ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Enter side b= ");
                var b = double.Parse(Console.ReadLine());
                var area = a * b;
                Console.WriteLine("{0}", Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                Console.Write("Enter radius r= ");
                var r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;
                Console.WriteLine("{0}", Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                Console.Write("Enter side a= ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Enter hight h= ");
                var h = double.Parse(Console.ReadLine());
                var area = a * h / 2;
                Console.WriteLine("{0}", Math.Round (area,3));
            }
        }
    }
}
