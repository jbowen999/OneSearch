using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSearch.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BinarySearch_TargetIsHigherInArray_ShouldReturn_7()
        {
            // Arrange
            int[] arr = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };
            // Act
            int single = Program.findSingle(arr);
            // Assert
            Assert.AreEqual(single, 7);

        }

        [TestMethod()]
        public void BinarySearch_TargetIsLowerInArray_ShouldReturn_2()
        {
            int[] arr = { 1, 1, 2, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
            int single = Program.findSingle(arr);
            Assert.AreEqual(single, 2);

        }

        [TestMethod()]
        public void BinarySearch_TargetIsInLargeArray_ShouldReturn_12()
        {
            int[] arr = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17, 18, 18, 19, 19, 20, 20 };
            int single = Program.findSingle(arr);
            Assert.AreEqual(single, 12);

        }



        [TestMethod()]
        public void BinarySearch_TargetNotInArray_ShouldReturnNegativeOne()
        {
            int[] arr = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
            int single = Program.findSingle(arr);
            Assert.AreEqual(single, -1);

        }


    }
}