using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildShop.MasterDetailPage;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WildShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pgPrincipal : ContentPage
	{
		public pgPrincipal ()
		{
			InitializeComponent ();
		}

        private async void BTn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MasterDetail());
        }

        private async void BTn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }
    }
}