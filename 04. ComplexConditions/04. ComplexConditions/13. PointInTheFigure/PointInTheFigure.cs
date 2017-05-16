using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if ((x>0)&&(x<3*a)&&(y>0)&& (y<=a))
            {
                if ((x>0)&&(x<3*a)&&(y>0)&&(y<a))
                {
                    Console.WriteLine("Inside");
                }
                else if ((x > a) && (x < 2 * a) && (y == a))
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }
            else if ((x>= a)&&(x< 2*a)&&(y>a)&&(y<=4*a))
            {
                if ((x>a)&&(x<2*a)&&(y>a)&&(y<4*a))
                {
                    Console.WriteLine("Inside");
                }else if ((x>a)&&(x< 2*a)&&(y==a))
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Border");
                }
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
