using EticketApp.Views;
using Xamarin.Forms;

namespace EticketApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DevExpress.XamarinForms.DataForm.Initializer.Init();
            MainPage = new NavigationPage(new HomeView());
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
