using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine().ToLower();
            var Holidays = int.Parse(Console.ReadLine());
            var weekends = int.Parse(Console.ReadLine());
            if (yearType == "leep")
            {
                var gamesInSofia = (48 - weekends) * (3.0 / 4);
                var gamesInHometown = weekends;
                var gamesDoringHolidays = Holidays * (2.0 / 3);
                var numberOfGmaes = gamesInSofia + gamesInHometown + gamesInHometown;
                var leapYear = numberOfGmaes * 0.15;
                var totalNumberOfGames = numberOfGmaes + leapYear;
                Console.WriteLine(Math.Truncate(totalNumberOfGames));
            }
            else if (yearType == "normal")
            {
                var gamesInSofia = (48 - weekends) * (3.0 / 4);
                var gamesInHometown = weekends;
                var gamesDoringHolidays = Holidays * (2.0 / 3);
                var numberOfGmaes = gamesInSofia + gamesInHometown + gamesInHometown;
                Console.WriteLine(Math.Truncate(numberOfGmaes));
            }
        }
    }
}
