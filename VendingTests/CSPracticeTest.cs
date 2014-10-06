using CSPractice;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingTests
{
    [TestClass]
    public class CSPracticeTest
    {
        [TestMethod]
        public void Too_Little_Money()
        {
            // arrange
            double userMoney = .5;
            bool expected = false;
            Vending test = new Vending();

            // act
            bool actual = test.checkAndCharge(userMoney);

            // assert
            Assert.AreEqual(expected, actual, "It is not charging properly.");
        }
        [TestMethod]
        public void Enough_Money()
        {
            //arrange
            double userMoney = 1;
            bool expected = true;
            Vending test = new Vending();

            //act
            bool actual = test.checkAndCharge(userMoney);

            // assert
            Assert.AreEqual(expected, actual, "It is not charging properly.");
        }
    }
}
