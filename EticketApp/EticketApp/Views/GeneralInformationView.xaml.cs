using EticketApp.Models;
using EticketApp.ViewModels;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace EticketApp.Views
{
    public partial class GeneralInformationView : ContentPage
    {
        public GeneralInformationView()
        {
            InitializeComponent();
            dataForm.DataObject = new GeneralInformation();
            NavigationPage.SetHasNavigationBar(this, false);

            cargaDatos();
        }

        private void cargaDatos()
        {
            var JsonStr = Preferences.Get("GeneralInfo", "");
            if (string.IsNullOrWhiteSpace(JsonStr) == false)
            {
                var obj = JsonConvert.DeserializeObject<GeneralInformation>(JsonStr);
                dataForm.DataObject = obj;
            }
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

        private void Button_Clicked(object sender, EventArgs e)
        {

            Preferences.Remove("GeneralInfo");
            var json = JsonConvert.SerializeObject(dataForm.DataObject);
            Preferences.Set("GeneralInfo", json);
            Navigation.PopAsync();
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