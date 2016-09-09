using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecimalToRomanLibrary;

namespace DecimalToRomanTester
{
    [TestClass]
    public class DecimalToRomanUnitTests
    {
        [TestMethod]
        public void DecimalToRomanConvertor_When1_ReturnI()
        {
            //Arrange
            int decimalNum = 1;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("I", roman);
        }
    }
}
