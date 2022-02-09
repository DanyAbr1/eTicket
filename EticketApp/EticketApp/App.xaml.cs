using EticketApp.ViewModels;
using EticketApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EticketApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainInformationView();
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
