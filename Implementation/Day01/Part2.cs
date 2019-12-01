using System;
using System.Collections.Generic;
using System.Linq;

namespace Day01
{
    public class Part2
    {
        public static long CalculateFuelRequired(long mass)
        {
            long fuelRequired = (long)(Math.Floor(mass / 3.0) - 2.0);
            if (fuelRequired <= 0)
                return 0;
            else
                return fuelRequired + CalculateFuelRequired(fuelRequired);
        }
        
        public static long CalculateFuelRequiredForMultiples(List<long> masses)
        {
            return masses.Sum(x => CalculateFuelRequired(x));
        }
    }
}
