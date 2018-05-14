using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

namespace UnitTestLagerverwaltung
{
    [TestClass]
    public class LagerverwaltungTest
    {
        Lager Lager1 = new Lager();
        string Ort;
        int BestandKoeln;
        int BestandBonn;
        int GesamtLagerbestand;
        

        [TestMethod]
        public void Buchen()
        {
            GesamtLagerbestand = BestandBonn + BestandKoeln;
            GesamtLagerbestand = GesamtLagerbestand - 500;
            if(GesamtLagerbestand == 0)
            {
                BestandKoeln = 0;
                BestandBonn = 0;
            }

        }

        [TestMethod]
        public void Umlagern()
        {
            BestandKoeln = 6000;
            BestandBonn = 10000;
            if (BestandBonn == 10000)
            {

            }

        }

    }
}
