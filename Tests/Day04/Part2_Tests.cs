using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace Day04
{
    public class Part2_Tests
    {

        [Theory]
        [InlineData("112233", true)]
        [InlineData("123444", false)]
        [InlineData("123440", false)]
        [InlineData("124444", false)]
        [InlineData("111122", true)]
        [InlineData("122670", false)]
        public void BaseCases(string password, bool isValidExpected)
        {
            
            bool isValid = Part2.IsValidPassword(password);
            Assert.Equal(isValidExpected, isValid);
        }

        [Fact]
        public void Part2Answers()
        {
            string s1 = "278384";
            string s2 = "824795";

            long result = Part2.NumberOfPasswords(s1, s2);

            Assert.Equal(603, result);
        }
    }
}
