using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EticketApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainInformationView : ContentPage
    {
        public MainInformationView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new GenereateQrView());
        }
    }
}