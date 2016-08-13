using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateAnInstance()
        {
        //Arrange

        //Act
        Fibonacci testFibonacci = new Fibonacci();


            //Assert
            Assert.IsNotNull(testFibonacci);
        }

        [TestMethod]
        public void FibonacciSequence()
        {
            //Arrange
            Fibonacci testFibonacci = new Fibonacci();

            //Act
            List<int> FibonacciSequence = testFibonacci.Sequence(10);
            //Assert
            CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, FibonacciSequence);
        }
    }
}
