using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13.ThousandDaysAfterBirth
{
    class ThousandDaysAfterBirth
    {
        static void Main(string[] args)
        {
            string datatain = Console.ReadLine();
            DateTime dateout = DateTime.ParseExact(datatain, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dateout.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
