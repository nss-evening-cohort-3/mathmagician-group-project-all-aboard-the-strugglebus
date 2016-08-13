using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void CanCreateAnInstanceOfOdd()
        {
            Odd testOdd = new Odd();

            Assert.IsNotNull(testOdd);
        }

        [TestMethod]
        public void CreatingAnIterationList()
        {
            Odd testOdd = new Odd();
            List<int> ReturnList = testOdd.Iterate(3);
       
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5 }, ReturnList);
        }
    }
}