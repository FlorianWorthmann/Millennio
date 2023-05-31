using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPR_Millennio.@class
{
    internal class Kredit
    {
        private float kreditHoehe;

        public float KreditHoehe
        {
            get { return kreditHoehe; }
            set { kreditHoehe = value; }
        }

        private float zins;

        public float Zins
        {
            get { return zins; }
            set { zins = value; }
        }

        public Kredit(float kreditHoehe, float zins)
        {
            KreditHoehe = kreditHoehe;
            Zins = zins;
        }

        public float Einzahlen(float einzahlung)
        {
            return 0;
        }
    }
}
