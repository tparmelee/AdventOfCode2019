using System;
using System.Collections.Generic;
using System.Linq;

namespace Day01
{
    public class Part1
    {
       public static long CalculateFuelRequired(long mass)
        {
            return (long)(Math.Floor(mass / 3.0) - 2.0);
        }

        public static long CalculateFuelRequiredForMultiples(List<long> masses)
        {
            return masses.Sum(x => CalculateFuelRequired(x));
        }
    }
}
