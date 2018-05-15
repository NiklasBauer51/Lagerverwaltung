using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLagerverwaltung
{
    [TestClass]
    public class LagerverwaltungTest
    {

        [TestMethod]
        [TestCategory("Buchen")]
        public void BuchenTest()
        {
            LagerTest Lagersicht1 = new LagerTest();
            int GesamtLagerbestand = Lagersicht1.Buchen(200, 301); ;
            Assert.AreEqual(GesamtLagerbestand, 1);
        }

        [TestMethod]
        [TestCategory("ArgumentOutOfRangeException")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UmlagernTest()
        {
            LagerTest Lagersicht2 = new LagerTest();
            Lagersicht2.Umlagern(10001, 6000);
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Auslagern")]
        public void AuslagernTest()
        {
            LagerTest Lagersicht3 = new LagerTest();
            int Gesamtlagerbestand = Lagersicht3.Auslagern(100,500);
            Assert.AreEqual(Gesamtlagerbestand, 600);
        }

        [TestMethod]
        [TestCategory("ArgumentOutOfRangeException")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void KaufenTest()
        {
            LagerTest Lagersicht4 = new LagerTest();
            Lagersicht4.Kaufen(500);
            Assert.Fail();
        }

    }
}
