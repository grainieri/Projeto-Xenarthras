using PCC.Paginas;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Plugin.Media.CrossMedia.Current.Initialize();
            if (App.Current.Properties.ContainsKey("Usuario"))
            {
                MainPage = new AppBase.Menu();
            }
            else
            {
                MainPage = new Paginas.Login();
            }
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
