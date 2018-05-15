using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLagerverwaltung
{
    class LagerTest
    {

        public int Buchen(int BestandBonn, int BestandKoeln)
        {
            BestandBonn = BestandBonn - 200;
            BestandKoeln = BestandKoeln - 300;

            //BestandBonn = BestandBonn - 199;
            //BestandKoeln = BestandKoeln - 301;

            return BestandBonn + BestandKoeln;
        }

        public void Umlagern(int BestandBonn, int BestandKoeln)
        {
            if(BestandBonn > 10000)
            {
                throw new ArgumentOutOfRangeException();
            }

        }


        public int Auslagern(int BestandLeverkusen, int BestandKoeln)
        {
            BestandLeverkusen = 100;
            BestandKoeln = 500;

            BestandKoeln = BestandKoeln + BestandLeverkusen;
            BestandLeverkusen = 0;

            return BestandKoeln + BestandLeverkusen;
        }

        public void Kaufen(int BestandKoeln)
        {
            int Kaufmenge = -100;

            if(Kaufmenge < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
