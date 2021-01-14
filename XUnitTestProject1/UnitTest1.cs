using System;
using Xunit;
using Lab03;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //==================================================== Challenge 1 =======================================================================
        [Fact]
        public void StringNums()
        {
            string[] arr = { "1", "2", "3" };
            Assert.Equal(6, Program.MultiplyInput(arr));
        }
        [Fact]
        public void MoreThan3Nums()
        {
            string[] arr = { "1", "2", "3", "4", "5", "6"};
            Assert.Equal(6, Program.MultiplyInput(arr));
        }
        [Fact]
        public void LessThan3Nums()
        {
            string[] arr = { "1", "2" };
            Assert.Equal(0, Program.MultiplyInput(arr));
        }
        [Fact]
        public void NegativeNums()
        {
            string[] arr = { "-1", "2", "3" };
            Assert.Equal(-6, Program.MultiplyInput(arr));
        }
        //==================================================== Challenge 4 =======================================================================

        [Fact]
        public void DifferentArrSize()
        {
            int[] arr = { 1, 1, 2 };
            Assert.Equal(1, Program.MostCommonNumber(arr));
        }
        [Fact]
        public void AllSameNum()
        {
            int[] arr = { 1, 1, 1, 1 };
            Assert.Equal(1, Program.MostCommonNumber(arr));
        }
        [Fact]
        public void NoDupes()
        {
            int[] arr = { 1, 2, 3 };
            Assert.Equal(1, Program.MostCommonNumber(arr));
        }
        [Fact]
        public void allSameNum()
        {
            int[] arr = { 1, 1, 2, 2, 3, 3 };
            Assert.Equal(1, Program.MostCommonNumber(arr));
        }
        //==================================================== Challenge 5 =======================================================================

        [Fact]
        public void ArrWithNegNums()
        {
            int[] arr = { -1, 1, 2, 2, 3, 3 };
            Assert.Equal(3, Program.FindMax(arr));
        }
        [Fact]
        public void AllSameVal()
        {
            int[] arr = { 2, 2, 2, 2};
            Assert.Equal(2, Program.FindMax(arr));
        }
        //==================================================== Challenge 6 =======================================================================

    }
}
