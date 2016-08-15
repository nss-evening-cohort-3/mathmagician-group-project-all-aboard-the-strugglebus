using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimesTest
    {
        [TestMethod]
        public void PrimesCreateAnInstance()
        {
            //Arrange

            //Act
            Primes testPrimes = new Primes();

            //Assert
            Assert.IsNotNull(testPrimes);
        }

        [TestMethod]
        public void FirstPrime()
        {
            //Arrange
            Primes myPrimes = new Primes();

            //Act
            int InitialPrime = myPrimes.StartofPrimes();

            //Assert
            Assert.AreEqual(2, InitialPrime);
        }

        [TestMethod]
        public void NextPrime()
        {
            //Arrange
            Primes myPrimes = new Primes();

            //Act
            int SecondPrime = myPrimes.AnotherPrime(3);

            //Assert
            Assert.AreEqual(3, SecondPrime);
        }

        [TestMethod]
        public void PrimeList()
        {
            //Arrange
            Primes myPrimes = new Primes();

            //Act
            List<int> PrimeNumbersList = myPrimes.ListPrimes(8);
            List<int> ExpectedPrimes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 };

            //Assert
            Assert.AreEqual(ExpectedPrimes.Count, PrimeNumbersList.Count);
            CollectionAssert.AreEqual(PrimeNumbersList, ExpectedPrimes);
        }
    }
}
