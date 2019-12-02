using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace Day02
{
    public class Part1_Tests
    {
        [Fact]
        public void SimpleProgram0()
        {
            int[] baseProgram = new int[] { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            int[] actual = Part1.RunIntProgram(baseProgram);
            int[] expected = new int[] { 3500,9,10,70,2,3,11,0,99,30,40,50 };

            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void SimpleProgram1()
        {
            int[] baseProgram = new int[] { 1, 0, 0, 0, 99 };
            int[] actual = Part1.RunIntProgram(baseProgram);
            int[] expected = new int[] { 2, 0, 0, 0, 99 };

            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void SimpleProgram2()
        {
            int[] baseProgram = new int[] { 2, 3, 0, 3, 99 };
            int[] actual = Part1.RunIntProgram(baseProgram);
            int[] expected = new int[] { 2, 3, 0, 6, 99 };

            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void SimpleProgram3()
        {
            int[] baseProgram = new int[] { 2, 4, 4, 5, 99, 0 };
            int[] actual = Part1.RunIntProgram(baseProgram);
            int[] expected = new int[] { 2, 4, 4, 5, 99, 9801 };

            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void SimpleProgram4()
        {
            int[] baseProgram = new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            int[] actual = Part1.RunIntProgram(baseProgram);
            int[] expected = new int[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 };

            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void Part1Answer()
        {
            int[] inState1202 = Part1.PutProgramIntoState1202(workingGravityProgram);

            int[] actual = Part1.RunIntProgram(inState1202);
            int expected = 3306701;

            Assert.Equal(expected, actual[0]);
        }


        private static readonly int[] workingGravityProgram = new int[]
        {
            1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,13,1,19,1,9,19,23,2,23,13,27,1,27,9,31,
            2,31,6,35,1,5,35,39,1,10,39,43,2,43,6,47,1,10,47,51,2,6,51,55,1,5,55,59,
            1,59,9,63,1,13,63,67,2,6,67,71,1,5,71,75,2,6,75,79,2,79,6,83,1,13,83,87,
            1,9,87,91,1,9,91,95,1,5,95,99,1,5,99,103,2,13,103,107,1,6,107,111,1,9,111,
            115,2,6,115,119,1,13,119,123,1,123,6,127,1,127,5,131,2,10,131,135,2,135,
            10,139,1,13,139,143,1,10,143,147,1,2,147,151,1,6,151,0,99,2,14,0,0
        };

    }
}
