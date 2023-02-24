using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildShop.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WildShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registro : ContentPage
	{
		public Registro ()
		{
			InitializeComponent ();
		}

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            if(validarDatos())
            {
                Usuarios Usu = new Usuarios
                {
                    Nombre = txtNombre.Text,
                    Email = txtEmail.Text,
                    Password = int.Parse(txtPassword.Text),
                    Password2 = int.Parse(txtPassword2.Text)

                };
                await App.SQLiteDB.SaveUsuarioAsync(Usu);
                txtNombre.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtPassword2.Text = "";
                await DisplayAlert("Registro", "El registro fue exitoso", "Aceptar");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Advertencia", "Debe llenar todos los campos", "Aceptar");
            }

        }

        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;

            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                respuesta = false;

            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                respuesta = false;

            }
            else if (string.IsNullOrEmpty(txtPassword2.Text))
            {
                respuesta = false;

            }

            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}