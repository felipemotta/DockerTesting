using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevExperience.UnitUnderTest.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void ShouldSortLongList()
        {
            // Arrange
            var expectedSortedList = new List<long>() { 0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 46, 55 };
            var inputList = new List<long>() { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };

            // Act
            inputList.QuickSort();

            // Assert
            inputList.Should().BeEquivalentTo(expectedSortedList, options => options.WithStrictOrdering());
        }
    }
}
