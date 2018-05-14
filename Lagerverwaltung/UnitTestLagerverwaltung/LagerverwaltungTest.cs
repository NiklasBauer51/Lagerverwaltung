using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

namespace UnitTestLagerverwaltung
{
    [TestClass]
    public class LagerverwaltungTest
    {

        [TestMethod]
        [TestCategory("Buchen")]
        public void BuchenTest()
        {
            Lager Lager1 = new Lager();
            int GesamtLagerbestand = Lager1.Buchen(200, 301); ;
            Assert.AreEqual(GesamtLagerbestand, 1);
        }

        [TestMethod]
        [TestCategory("ArgumentOutOfRangeException")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UmlagernTest()
        {
            Lager Lager1 = new Lager();
            Lager1.Umlagern(10001, 6000);
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Auslagern")]
        public void AuslagernTest()
        {
            Lager Lager1 = new Lager();
            int Gesamtlagerbestand = Lager1.Auslagern(100,500);
            Assert.AreEqual(Gesamtlagerbestand, 600);

        }

        [TestMethod]
        [TestCategory("ArgumentOutOfRangeException")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void KaufenTest()
        {
            Lager Lager1 = new Lager();
            Lager1.Kaufen(500);
            Assert.Fail();

        }

    }
}
