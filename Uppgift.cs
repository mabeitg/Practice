using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Uppgift
    {
        int faktor1, faktor2, produkt;

        public Uppgift(int faktor1, int faktor2)
        {
            this.faktor1 = faktor1;
            this.faktor2 = faktor2;
            produkt = faktor1 * faktor2;
        }

        public bool Rätta(int svar)
        {
            if (svar == produkt)
                return true;

            return false;
        }

        public Uppgift Copy()
        {
            return new Uppgift(faktor1, faktor2);
        }

        public string Text
        {
            get
            {
                return faktor1 + " x " + faktor2 + " = ";
            }
        }

    }
}
