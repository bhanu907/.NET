﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                s = s + i;
            }
            Console.WriteLine("sum of numbers={0}",s);
        }
    }
}
