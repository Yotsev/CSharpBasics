using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class MachTickets
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var status = Console.ReadLine().ToLower();
            var group = int.Parse(Console.ReadLine());
            var tickets = 249.99;
            var spend = 0.0;
            //tickets chek
            if (status == "vip")
            {
                tickets = 499.99;
            }
            // group chek
            if (group < 5)
            {
                spend = budget * 0.75;
            }
            else if (group < 10)
            {
                spend = budget * 0.60;
            }
            else if (group < 25)
            {
                spend = budget * 0.50;
            }
            else if (group < 50)
            {
                spend = budget * 0.40;
            }
            else
            {
                spend = budget * 0.25;
            }

            var groupTickets = group * tickets;
            var left = (budget - spend);
            var afterTickets = Math.Abs (left - groupTickets); 
            if (spend >= groupTickets)
            {
                Console.WriteLine("Yes! you have {0:f2} leva left.",afterTickets);
            }
            else
            {
                Console.WriteLine("Not enough money! you need {0:f2} leva.",afterTickets);
            }
        }
    }
}
