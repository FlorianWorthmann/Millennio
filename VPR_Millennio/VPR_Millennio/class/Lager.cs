using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPR_Millennio.enumeration;

namespace VPR_Millennio.@class
{
    internal class Lager //: Gebaeude
    {
        private int lagerplatz;

        public int Lagerplatz
        {
            get { return lagerplatz; }
            set { lagerplatz = value; }
        }


        //public Lager(string bezeichnung, Kategorie kategorie, Feldanforderungen feldanforderungen, int lagerplatz) : base(bezeichnung, kategorie, feldanforderungen)
        //{
        //    Lagerplatz = lagerplatz;
        //}

        public void lagerplatzBerechnen()
        {

        }
    }
}
