using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace Day04
{
    public class Part1_Tests
    {

        [Theory]
        [InlineData("111111", true)]
        [InlineData("223450", false)]
        [InlineData("123789", false)]
        public void BaseCases(string password, bool isValidExpected)
        {
            bool isValid = Part1.IsValidPassword(password);
            Assert.Equal(isValidExpected, isValid);
        }

        [Fact]
        public void Part1Answers()
        {
            string s1 = "278384";
            string s2 = "824795";

            long result = Part1.NumberOfPasswords(s1, s2);

            Assert.Equal(921, result);
        }

    
    }
}
