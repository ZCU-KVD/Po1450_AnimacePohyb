namespace Po1450_AnimacePohyb.Models
{
	public class Pozice
	{
		public Pozice(int pozX, int pozY, int velikostObrProcenta, int pruhlednostProcenta)
		{
			PozX = pozX;
			PozY = pozY;
			VelikostObrProcenta = velikostObrProcenta;
			PruhlednostProcenta = pruhlednostProcenta;
		}

		private int PozX { get;  }
		private int PozY { get; }
		public int VelikostObrProcenta { get; }
		private int PruhlednostProcenta { get;  }

		public string Style => $"left: {PozX}px; top: {PozY}px; opacity: {PruhlednostProcenta / 100.0};";

	}
}
