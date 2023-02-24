using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WildShop.Data;
using WildShop.Models;
using WildShop.MasterDetailPage;

using System.IO;



[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WildShop
{
    public partial class App : Application
    {
        static SQLitehelper db;

        public static IMasterDetailPageController MasterDet
        {
            get;

            set;

        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new pgPrincipal());
        }

        public static SQLitehelper SQLiteDB
        {
            get
            {
                if (db==null)
                {
                    db = new SQLitehelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bdUsuarios"));


                }
                return db;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
