﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(new string ('*' , 10));
            }
        }
    }
}
