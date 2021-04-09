using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation
{
    public class IntProgram
    {

        public static int[] RunIntProgram(int[] intProgram)
        {
            int i = 0;
            List<int> output = new List<int>();
            while (intProgram[i] != 99)
            {
                int resultLoc = intProgram[i + 3];
                int part1Loc = intProgram[i + 1];
                int part2Loc = intProgram[i + 2];
                if (intProgram[i] == 1)
                {
                    intProgram[resultLoc] = intProgram[intProgram[i + 1]] + intProgram[intProgram[i + 2]];
                    i += 4;
                }
                else if (intProgram[i] == 2)
                {
                    intProgram[resultLoc] = intProgram[intProgram[i + 1]] * intProgram[intProgram[i + 2]];
                    i += 4;
                }
                else if (intProgram[i] == 3)
                {
                    intProgram[0] = intProgram[intProgram[i + 1]];
                    i += 2;
                }
                else if (intProgram[i] == 4)
                {
                    intProgram[resultLoc] = intProgram[intProgram[i + 1]] * intProgram[intProgram[i + 2]];
                    i += 2;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            return intProgram;
        }

        public static int[] PutProgramIntoState(int[] intProgram, int noun, int verb)
        {
            intProgram[1] = noun;
            intProgram[2] = verb;
            return intProgram;
        }
    }
}
