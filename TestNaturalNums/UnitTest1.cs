using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using acfour_cristian_sala;

namespace UnitTestNaturalNums
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(1, true)]  //Cas limit: nombre minim acceptat
        [DataRow(5, true)]  //Nombre valid
        [DataRow(-1, false)]  //Cas limit: nombre maxim acceptat
        [DataRow(-10, false)]  //Nombre invalid
        public void CheckNaturalNumber_ValidatesCorrectly(int number, bool expected)
        {
            bool result = NaturalNums.CheckNaturalNumber(number);

            Assert.AreEqual(expected, result);
        }
    }
}
