﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards
{
    class Program
    {
        public static void DisplayFeetAndInches(int inches)
        {
            Console.WriteLine(inches / 12 + " feet, and " + inches % 12 + " inches.");
        }

            static void Main(string[] args)
            {
                   int inches =75;

                   DisplayFeetAndInches(inches);
            }

      
    }
}
