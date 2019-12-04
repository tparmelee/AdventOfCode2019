using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day04
{
    public class Part2
    {
        public static bool IsValidPassword(string password)
        {
            if (password.Length != 6)
                return false;

            Dictionary<int, int> counts = new Dictionary<int, int>();
            int prev = -1;
            for (int i = 0; i < password.Length; i++)
            {
                int curVal = int.Parse(password[i].ToString());

                // sorted
                if (curVal < prev)
                    return false;

                if (counts.ContainsKey(curVal))
                    counts[curVal]++;
                else
                    counts[curVal] = 1;

                prev = curVal;
            }
            
            bool adjacentMatchExists = false;
            foreach (var pair in counts)
            {
                if (pair.Value == 2)
                    adjacentMatchExists = true;
            }

            return adjacentMatchExists;
        }

        public static int NumberOfPasswords(string s1, string s2)
        {
            int p1 = int.Parse(s1);
            int p2 = int.Parse(s2);

            int count = 0;
            for (int i = p1; i <= p2; i++)
            {
                if (IsValidPassword(i.ToString()))
                    count++;
            }

            return count;
        }

    }
}
