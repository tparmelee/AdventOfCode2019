using Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;



namespace Day05
{
    public class Part1_Tests
    {

        [Fact]
        public void Program0()
        {

            int[] baseProgram = new int[] { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            int[] actual = IntProgram.RunIntProgram(baseProgram);
            int[] expected = new int[] { 3500, 9, 10, 70, 2, 3, 11, 0, 99, 30, 40, 50 };

            Assert.True(expected.SequenceEqual(actual));
        }

        //[Fact]
        //public void Part1Answers()
        //{
        //    string s1 = "278384";
        //    string s2 = "824795";

        //    long result = Part1.NumberOfPasswords(s1, s2);

        //    Assert.Equal(921, result);
        //}

    
    }
}
