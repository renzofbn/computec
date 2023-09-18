using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;


namespace computecApp
{
    public partial class App : Application
    {
        private static SQLiteHelper _database;
        public static SQLiteHelper Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "computecApp.db3"));
                }
                return _database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SignInPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
