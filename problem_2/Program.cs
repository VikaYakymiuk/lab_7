﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string driver_name = Console.ReadLine();
            IFerrari ferrari = new Ferrari(driver_name);
            Console.WriteLine(ferrari);
        }
    }
}
