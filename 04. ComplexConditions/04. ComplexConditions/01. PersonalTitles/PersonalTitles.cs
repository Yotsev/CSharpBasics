﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (age <16)
            {
                if (gender == "m") Console.WriteLine("Master");
                else if (gender == "f") Console.WriteLine("Miss");       
            }
            else
            {
                if (gender == "m") Console.WriteLine("Mr.");
                else if (gender == "f") Console.WriteLine("Ms.");
            }
        }
    }
}
