using EticketApp.ViewModels;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace EticketApp.Views
{
    public partial class GeneralInformationView : ContentPage
    {
        public GeneralInformationView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new GenereateQrView());
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var VM = ((GeneralInformationViewModel)this.BindingContext);
            if (VM != null)
            {
                VM.LoadStateByCountry();
            }
        }

        //private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    var VM = ((GeneralInformationViewModel)this.BindingContext);
        //    if (VM != null)
        //    {
        //        VM.LoadCityByState();
        //    }
        //}
    }
}