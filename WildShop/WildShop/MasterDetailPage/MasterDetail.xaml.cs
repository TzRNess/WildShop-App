using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WildShop.MasterDetailPage;
using WildShop.Data;
using WildShop.Models;


namespace WildShop.MasterDetailPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetail : IMasterDetailPageController
	{
		public MasterDetail ()
		{
			InitializeComponent ();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
            App.MasterDet = this;

		}
	}
}