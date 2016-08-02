using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ASP.NET._1607.Day1.Task3.Suhov.Tests
{
    [TestClass]
    public class CalculationFibonacciTest
    {
        [TestMethod]
        public void TestCalculateValues()
        {
            // Arrange
            var arrayFibonacci = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
            // Act
            // Assert
            int i = 0;
            arrayFibonacci.ForEach(delegate (int numb) {
                Assert.AreEqual(CalculationFibonacci.Calculate(i),numb);
                i++;
            });
        }
        [TestMethod]
        public void TestCalculateYieldValues()
        {
            // Arrange
            var arrayFibonacci = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
            // Act
            var fibonacci = new FibonacciYield(arrayFibonacci.Count);
            // Assert
            int i = 0;
            foreach(var item in fibonacci) {
                Assert.AreEqual(item, arrayFibonacci[i]);
                i++;
            };
        }
    }
}
