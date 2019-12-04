using System;
using System.Collections.Generic;
using System.Linq;

namespace Day04
{
    public class P1
    {

        public static bool IsValidPassword(string password)
        {
            if (password.Length != 6)
                return false;


            bool adjacentMatchExists = false;
            for (int i = 0; i < password.Length - 1; i++)
            {
                int i0 = int.Parse(password[i].ToString());
                int i1 = int.Parse(password[i+1].ToString());

                if (i1 < i0)
                    return false;
                if (i0 == i1)
                    adjacentMatchExists = true;
            }

            return adjacentMatchExists;
        }

        public static long NumberOfPasswords(string s1, string s2)
        {
            long p1 = long.Parse(s1);
            long p2 = long.Parse(s2);

            long count = 0;

            for(long i = p1; i <= p2; i++)
            {
                if (IsValidPassword(i.ToString()))
                    count++;
            }

            return count;
        }
    }
}
