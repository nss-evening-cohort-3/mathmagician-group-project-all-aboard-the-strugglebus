using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void CreatingAnIterationList()
        {
            Even testEven = new Even();
            List<int> ReturnList = testEven.Iterate(3);
       
            CollectionAssert.AreEqual(new List<int> { 0, 2, 4 }, ReturnList);
        }
    }
}