using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {

            //Arrange

            //Act
            Integer my_int = new Integer(); //what i want to be able to do

            //Assert
            Assert.IsNotNull(my_int);
        }

        [TestMethod]
        public void IntegerFirstInstance()
        {
            //Arrange
            Integer my_int = new Integer();

            //Act
            int NumberZero = my_int.GetFirstNumber();


            //Assert
            Assert.AreEqual(0, NumberZero);
        }

        [TestMethod]
        public void IntegerGetNext()
        {
            //Arrange
            Integer my_int = new Integer();

            //Act
            int NextNumber = my_int.GetNext(42);

            //Assert
            Assert.AreEqual(43, NextNumber);
        }

        [TestMethod]
        public void MakeAList()
        {
            //Arrange
            Integer my_int = new Integer();

            //Act
            List<int> NumberList = my_int.GetList(10);

            //Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6,7, 8, 9, 10 }, NumberList);
        }


    }
}
