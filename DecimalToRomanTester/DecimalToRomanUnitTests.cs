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

        [TestMethod]
        public void DecimalToRomanConvertor_When5_ReturnV()
        {
            //Arrange
            int decimalNum = 5;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("V", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When9_ReturnIX()
        {
            //Arrange
            int decimalNum = 9;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("IX", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When10_ReturnX()
        {
            //Arrange
            int decimalNum = 10;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("X", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When40_ReturnXL()
        {
            //Arrange
            int decimalNum = 40;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("XL", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When50_ReturnL()
        {
            //Arrange
            int decimalNum = 50;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("L", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When90_ReturnXC()
        {
            //Arrange
            int decimalNum = 90;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("XC", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When100_ReturnC()
        {
            //Arrange
            int decimalNum = 100;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("C", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When400_ReturnCD()
        {
            //Arrange
            int decimalNum = 400;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("CD", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When500_ReturnD()
        {
            //Arrange
            int decimalNum = 500;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("D", roman);
        }

        [TestMethod]
        public void DecimalToRomanConvertor_When900_ReturnCM()
        {
            //Arrange
            int decimalNum = 900;

            //Act
            string roman = DecimalToRomanConvertor.ConvertToRoman(decimalNum);

            //Assert
            Assert.AreEqual("CM", roman);
        }
    }
}
