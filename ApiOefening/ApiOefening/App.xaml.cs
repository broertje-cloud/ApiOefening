using ApiOefening.Logic;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiOefening
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Eindresultaten();
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
