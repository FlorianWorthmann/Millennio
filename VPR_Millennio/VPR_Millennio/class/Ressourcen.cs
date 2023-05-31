using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPR_Millennio.@class
{
    internal class Ressourcen
    {
		private string bezeichnung;

		public string Bezeichnung
		{
			get { return bezeichnung; }
			set { bezeichnung = value; }
		}

		private int mengeImLager;

		public int MengeImLager
		{
			get { return mengeImLager; }
			set { mengeImLager = value; }
		}

		public Ressourcen(string bezeichnung, int mengeImLager)
		{
			Bezeichnung = bezeichnung;
			MengeImLager = mengeImLager;
		}

		public int MengeAbziehen(int menge)
		{
			return 0;
		}

		public int MengeHinzufügen(int menge)
		{
			return 0;
		}

		public void UpdateUI()
		{

		}
	}
}
