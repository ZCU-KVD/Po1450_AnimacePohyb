
namespace Po1450_AnimacePohyb.Pages
{
	public partial class Animace1
	{
		private Models.Postava? Postava { get; set; }

		protected override void OnInitialized()
		{
			InicializaceHry();
			base.OnInitialized();
		}

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				// Zde můžete spustit animaci nebo jinou logiku po prvním vykreslení
				await Task.Run(Postava.Presun);
				StateHasChanged();
			}
			await base.OnAfterRenderAsync(firstRender);
		}

		#region Metody
		private void InicializaceHry()
		{
			Postava = new Models.Postava("img/Pes.png", "Maxipes", 150);
			Postava.PridejPozici(pozX: 45, pozY: 300, velikostObrProcenta: 70, pruhlednostProcenta: 100);
			Postava.PridejPozici(450,270,20,100);
			Postava.PridejPozici(840, 340, 80, 100);
			Postava.PridejPozici(110, 430, 100, 100);
		}
		#endregion
	}
}
