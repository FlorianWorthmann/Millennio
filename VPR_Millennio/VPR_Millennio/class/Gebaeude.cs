using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPR_Millennio.enumeration;

namespace VPR_Millennio.@class
{
    internal class Gebaeude
    {
		private string gebaeudename;

		public string Gebaeudename
        {
			get { return gebaeudename; }
			set { gebaeudename = value; }
		}

		private Ressources produktion;

		public Ressources Produktion
		{
			get { return produktion; }
			set { produktion = value; }
		}


		private bool tier_1;

		public bool Tier_1
		{
			get { return tier_1; }
			set { tier_1 = value; }
		}

		private bool tier_2;

		public bool Tier_2
		{
			get { return tier_2; }
			set { tier_2 = value; }
		}

		private bool tier_3;

		public bool Tier_3
		{
			get { return tier_3; }
			set { tier_3 = value; }
		}

		private int produktionsrate_1;

		public int Produktionsrate_1
		{
			get { return produktionsrate_1; }
			set { produktionsrate_1 = value; }
		}

		private int produktionsrate_2;

		public int Produktionsrate_2
		{
			get { return produktionsrate_2; }
			set { produktionsrate_2 = value; }
		}

		private int produktionsrate_3;

		public int Produktionsrate_3
		{
			get { return produktionsrate_3; }
			set { produktionsrate_3 = value; }
		}

		private int produktionskosten_1;

		public int Produktionskosten_1
		{
			get { return produktionskosten_1; }
			set { produktionskosten_1 = value; }
		}

		private int produktionskosten_2;

		public int Produktionskosten_2
		{
			get { return produktionskosten_2; }
			set { produktionskosten_2 = value; }
		}

		private int produktionskosten_3;

		public int Produktionskosten_3
		{
			get { return produktionskosten_3; }
			set { produktionskosten_3 = value; }
		}


		private Feldanforderungen feld;

        public Feldanforderungen Feld
        {
            get { return feld; }
            set { feld = value; }
        }

        private Kategorie kategorie;

		public Kategorie Kategorie
		{
			get { return kategorie; }
			set { kategorie = value; }
		}

		public Gebaeude(string gebaeudename, Ressources produktion, bool tier_1, bool tier_2, bool tier_3, int produktionsrate_1, int produktionsrate_2, int produktionsrate_3, 
			int produktionskosten_1, int produktionskosten_2, int produktionskosten_3, Feldanforderungen feld, Kategorie kategorie)
		{
			Gebaeudename = gebaeudename;
			Produktion = produktion;
			Tier_1 = tier_1;
			Tier_2 = tier_2;
			Tier_3 = tier_3;
			Produktionsrate_1 = produktionsrate_1;
			Produktionsrate_2 = produktionsrate_2;
			Produktionsrate_3 = produktionsrate_3;
			Produktionskosten_1 = produktionskosten_1;
			Produktionskosten_2 = produktionskosten_2;
			Produktionskosten_3 = produktionskosten_3;
			Feld = feld;
			Kategorie = kategorie;
		}
	}
}
