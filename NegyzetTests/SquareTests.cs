using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negyzet;

namespace NegyzetTests
{
    [TestClass]
    public class SquareTests
    {
        // Teszt változók
        static double oldal = 2;
        Square objTest = new Square(oldal);

        [TestMethod]
        public void AtmeroTest()
        {
            // Arrange
            double vartEredm = Math.Sqrt(8);

            // Act
            double kapottEredm = objTest.Atmero();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod]
        public void KeruletTest()
        {
            // Arrange
            double vartEredm = 8;

            // Act
            double kapottEredm = objTest.Kerulet();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod]
        public void TeruletTest()
        {
            // Arrange
            double vartEredm = 4;

            // Act
            double kapottEredm = objTest.Terulet();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod]
        public void TerfogatTest()
        {
            // Arrange
            objTest.Magas = 3;
            double vartEredm = 12;

            // Act
            double kapottEredm = objTest.OszlopTerfogat();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TerfogatHibaTest()
        {
            // Arrange
            objTest.Magas = 0;
            double vartEredm = 69;

            // Act
            double kapottEredm = objTest.OszlopTerfogat();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

    }
}
