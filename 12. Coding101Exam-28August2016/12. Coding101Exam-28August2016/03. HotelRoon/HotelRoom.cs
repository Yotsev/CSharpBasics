using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoon
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var mon = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var apartment = 0.0;
            
            if (mon == "May" || mon == "October")
            {
                studio = 50;
                apartment = 65;
                if (nights > 14)
                {
                    studio = studio - (studio * 0.30);
                }
                else if (nights > 7)
                {
                    studio = studio - (studio * 0.05);
                }
            }
           else if (mon == "June" || mon == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (nights > 14)
                {
                    studio = studio - (studio * 0.20);
                }
            }
            else if (mon == "July" || mon == "August")
            {
                studio = 76;
                apartment = 77;
            }

            if (nights > 14)
            {
                apartment = apartment - (apartment * 0.10);
            }


           var studioPrice = studio * nights;
           var apartmentPrice = apartment * nights;
           Console.WriteLine("Apartment: {0:f2} lv.",apartmentPrice);
           Console.WriteLine("Studio: {0:f2} lv.",studioPrice);
        }
    }
}
