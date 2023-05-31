using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPR_Millennio.@class
{
    internal class Destrikt
    {
		private Feld[][] felder;

		public Feld[][] Felder
		{
			get { return felder; }
			set { felder = value; }
		}

		private string destriktName;

		public string DestriktName
		{
			get { return destriktName; }
			set { destriktName = value; }
		}

		public Destrikt(Feld[][] felder, string destriktName)
		{
			Felder = felder;
			DestriktName = destriktName;
		}
		public void NameAendern()
		{

		}

		public void UpadeUI()
		{

		}
	}
}
