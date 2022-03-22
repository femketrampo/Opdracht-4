using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_4
{
    class Bankrekening
    {
        public double Balans;
        public double Limiet;
        public string Verrichtingen;

        public Bankrekening()
        {
            Balans = 0;
            Limiet = 0;
            Verrichtingen = "";
        }
    }
}
