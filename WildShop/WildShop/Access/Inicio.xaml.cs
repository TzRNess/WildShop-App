using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WildShop.MasterDetailPage;


namespace WildShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
		}

        private async void Btn2_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Registro());
        }

        private async void BTn1_Clicked(object sender, EventArgs e)
        {

            string sUsuario = txtUsuario.Text;
            string sPassword = txtPassword.Text;

            if((sUsuario == "Alejandro") && (sPassword == "12345"))
            {
                await Navigation.PushAsync(new MasterDetail());
            }

            else
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
                await DisplayAlert("Advertencia", "El usuario o contraseña ingresado no son correctos", "Aceptar");
              
            }

           
        }
    }
}