﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total bill amount");
            int total = Convert.ToInt32(Console.ReadLine());

            double tips=(total*(5/100.0));
            Console.WriteLine("The tips provided to the waiter is " + tips);
        }
    }
}
