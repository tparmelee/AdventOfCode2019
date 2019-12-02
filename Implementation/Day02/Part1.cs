using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    public class Part1
    {
       public static int[] RunIntProgram(int[] intProgram)
        {
            int i = 0;
            while(intProgram[i] != 99)
            {
                int resultLoc = intProgram[i + 3];
                int part1Loc = intProgram[i + 1];
                int part2Loc = intProgram[i + 2];
                if (intProgram[i] == 1)
                {
                    intProgram[resultLoc] = intProgram[part1Loc] + intProgram[part2Loc];
                }
                else if (intProgram[i] == 2)
                {
                    intProgram[resultLoc] = intProgram[part1Loc] * intProgram[part2Loc];
                }
                else
                {
                    throw new ArgumentException();
                }
                i += 4;
            }
            return intProgram;
        }

        public static int[] PutProgramIntoState1202(int[] intProgram)
        {
            intProgram[1] = 12;
            intProgram[2] = 2;
            return intProgram;
        }
    }
}
