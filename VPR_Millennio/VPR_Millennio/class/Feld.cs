using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPR_Millennio.enumeration;

namespace VPR_Millennio.@class
{
    internal class Feld
    {
		private Gebaeude gebaeude;

		public Gebaeude Gebaeude
		{
			get { return gebaeude; }
			set { gebaeude = value; }
		}

		private Feldanforderungen feldanforderungen;

		public Feldanforderungen Feldanforderungen
		{
			get { return feldanforderungen; }
			set { feldanforderungen = value; }
		}

		public Feld(Gebaeude gebaeude, Feldanforderungen feldanforderungen)
		{
			Gebaeude = gebaeude;
			Feldanforderungen = feldanforderungen;
		}

		public void Build(Gebaeude gebaeude)
		{

		}

		public void Tear()
		{

		}

		public void UpdateUI()
		{
				
		}
	}
}
