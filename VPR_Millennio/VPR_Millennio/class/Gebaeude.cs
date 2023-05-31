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
		private string bezeichnung;

		public string Bezeichnung
		{
			get { return bezeichnung; }
			set { bezeichnung = value; }
		}

		private Kategorie kategorie;

		public Kategorie Kategorie
		{
			get { return kategorie; }
			set { kategorie = value; }
		}

		private Feldanforderungen feldanforderungen;

		public Feldanforderungen Feldanforderungen
		{
			get { return feldanforderungen; }
			set { feldanforderungen = value; }
		}

		public Gebaeude(string bezeichnung, Kategorie kategorie, Feldanforderungen feldanforderungen)
		{
			Bezeichnung = bezeichnung;
			Kategorie = kategorie;
			Feldanforderungen = feldanforderungen;
		}
	}
}
