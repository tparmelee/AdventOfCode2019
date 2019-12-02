using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    public class Part2
    {
        public static int FindNounVerbToGetOutput(int[] intProgram, int outputValueToFind)
        {

            for(int noun = 0; noun <=99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    int[] working = DeepClone(intProgram);
                    working = PutProgramIntoState(working, noun, verb);
                    int[] result = Part1.RunIntProgram(working);

                    if (result[0] == outputValueToFind)
                        return 100 * noun + verb;

                }
            }

            return - 1;
        }

        private static int[] DeepClone(int[] input)
        {
            int[] output = new int[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                output[i] = input[i];
            }
            return output;
        }

        public static int[] PutProgramIntoState(int[] intProgram, int noun, int verb)
        {
            intProgram[1] = noun;
            intProgram[2] = verb;
            return intProgram;
        }
    }
}
