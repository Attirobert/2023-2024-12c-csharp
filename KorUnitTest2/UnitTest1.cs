using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kor;
namespace KorUnitTest2
{
    [TestClass]
    public class KorClass_Test
    {
        private static double sugar = 3.0,
            vartEredm = 28.27,
                kapottEredm;
        KorClass kr = new KorClass(sugar);

        [TestMethod]
        public void TeruletTest()
        {
            //Arrange - Teszteset beállítása
            kr.setTerulet();

            // Act - Végrehajtás
            kapottEredm = Math.Round(kr.getTerulet(),2);

            // Assert - Ellenőrzés
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void KeruletTest()
        {
            //Arrange - Teszteset beállítása
            double vartEredm = 18.85;

            kr.setKerulet();

            // Act - Végrehajtás
            kapottEredm = Math.Round(kr.getKerulet(),2);

            // Assert - Ellenőrzés
            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
