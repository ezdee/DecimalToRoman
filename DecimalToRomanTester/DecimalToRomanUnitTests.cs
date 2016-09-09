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

        [TestMethod]
        public void DecimalToRomanConvertor_When4_ReturnIV()
        {
            //Arrange
            int decimalNum = 4;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("IV", roman);
        }
    }
}
