﻿using CalculatorLibWithoutMEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithoutMEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var add = new AddOperation();
            Console.WriteLine("Sum : " + add.Perform(10, 20));
        }
    }
}

// 1. Operation library
// 2. Printing 
