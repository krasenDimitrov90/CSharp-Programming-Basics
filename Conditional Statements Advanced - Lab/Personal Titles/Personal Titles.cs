﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (age < 16)
            {
                if (gender == 'f')
                {
                    Console.WriteLine("Miss");
                }
                else if (gender == 'm')
                {
                    Console.WriteLine("Master");
                }
            }

            else if (age >= 16)
            {
                if (gender == 'f')
                {
                    Console.WriteLine("Ms.");
                }
                else if (gender == 'm')
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
