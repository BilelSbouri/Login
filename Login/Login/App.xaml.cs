using CRMapp.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    public partial class App : Application
    {
        static DBCnx database;


        public static DBCnx Database
        {
            get
            {
                if (database == null)
                {
                    database = new DBCnx(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Database02.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
