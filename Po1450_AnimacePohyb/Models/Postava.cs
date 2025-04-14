namespace Po1450_AnimacePohyb.Models
{
	public class Postava
	{
		public Postava(string obrazek, string jmeno, int width)
		{
			Obrazek = obrazek;
			Jmeno = jmeno;
			Width = width;
		}
		#region Vlastnosti
		public string Obrazek { get;  }
		public string Jmeno { get; }
		public int AktualniPozice { get; private set; } = -1;
		private int Width { get;  }
		private List<Pozice> PoziceList { get; set; } = new List<Pozice>();

		public string Style
		{
			get
			{
				if (AktualniPozice<0)
				{
					return $"with: {Width}px;";
				}
				else
				{
					var pozice = PoziceList[AktualniPozice];
					return $"{pozice.Style} width:{Width * pozice.VelikostObrProcenta/100}px;";
				}
			}
		}
		#endregion

		#region Metody
		public void PridejPozici(int pozX, int pozY, int velikostObrProcenta, int pruhlednostProcenta)
		{
			var pozice = new Pozice(pozX, pozY, velikostObrProcenta, pruhlednostProcenta);
			PoziceList.Add(pozice);
		}

		public void Presun()
		{
			AktualniPozice += 1;
		}
		#endregion

	}
}
