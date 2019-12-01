using System;
using System.Collections.Generic;
using Xunit;


namespace Day01
{
    public class Part1_Tests
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void BaseCases(long mass, long expectedFuel)
        {
            long fuelRequired = Part1.CalculateFuelRequired(mass);
            Assert.Equal(fuelRequired, expectedFuel);
        }

        [Fact]
        public void Answer1()
        {
            List<long> masses = new List<long>() { 12, 14, 1969, 100756 };
            long fuelRequired = Part1.CalculateFuelRequiredForMultiples(masses);
            long expectedFuel = 34241;
            Assert.Equal(fuelRequired, expectedFuel);
        }

        [Fact]
        public void FinalAnswer()
        {
            long fuelRequired = Part1.CalculateFuelRequiredForMultiples(finalMassList);
            long expectedFuel = 3401852;
            Assert.Equal(fuelRequired, expectedFuel);
        }

        List<long> finalMassList = new List<long>()
        {
            91617,
            134652,
            101448,
            83076,
            53032,
            80487,
            106061,
            103085,
            71513,
            143874,
            102830,
            121433,
            139937,
            104468,
            53098,
            75999,
            113915,
            73992,
            90028,
            64164,
            101248,
            111333,
            89201,
            89076,
            129360,
            81573,
            54381,
            64105,
            104272,
            144188,
            81022,
            125558,
            87910,
            135654,
            110929,
            131610,
            147160,
            139648,
            118129,
            93967,
            123117,
            77927,
            112034,
            84847,
            145527,
            72652,
            123043,
            136324,
            71228,
            118583,
            56992,
            141812,
            60119,
            105185,
            97653,
            134563,
            54195,
            64473,
            75606,
            148515,
            88765,
            112562,
            52156,
            119805,
            117149,
            149791,
            128964,
            108955,
            55806,
            86025,
            148350,
            74382,
            73632,
            141124,
            101688,
            106829,
            132594,
            113645,
            90320,
            104874,
            95210,
            118499,
            56445,
            86371,
            113833,
            122860,
            112507,
            55964,
            105993,
            92005,
            83760,
            90258,
            56238,
            127426,
            147641,
            129484,
            107162,
            99535,
            107975,
            136238,
        };


    }
}
