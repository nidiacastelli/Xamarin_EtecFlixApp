using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EtecFlixApp.Filmes;

namespace EtecFlixApp.Categorias
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Aventura : ContentPage
	{
		public Aventura ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);


            logo.Source = ImageSource.FromResource("EtecFlixApp.Img.etecflix.png");

            btnAlladin.Source = ImageSource.FromResource("EtecFlixApp.Posters.alladin.jpg");
            btnCapitaMarvel.Source = ImageSource.FromResource("EtecFlixApp.Posters.capitamarvel.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("EtecFlixApp.Posters.panteranegra.jpg");
            btnShazam.Source = ImageSource.FromResource("EtecFlixApp.Posters.shazam.jpg");
            btnDumbo.Source = ImageSource.FromResource("EtecFlixApp.Posters.dumbo.jpg");
            btnVef.Source = ImageSource.FromResource("EtecFlixApp.Posters.vef.jpg");
        }


        private async void Btn_Open_Alladin(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Alladin());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void Btn_Open_CapitaMarvel(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CapitaMarvel());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void Btn_Open_PanteraNegra(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PanteraNegra());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void Btn_Open_Shazam(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Shazam());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
    }
}