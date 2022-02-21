
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DevExpress.XamarinForms.DataForm;
using EticketApp.Models;
using Xamarin.Essentials;
using Newtonsoft.Json;

namespace EticketApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MigratorialInformationView : ContentPage
    {
        public MigratorialInformationView()
        {
            InitializeComponent();
            dataForm.DataObject = new MigratorialInformation();
            NavigationPage.SetHasNavigationBar(this, false);
            cargaDatos();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Preferences.Remove("MigratorialInfo");
            var json = JsonConvert.SerializeObject(dataForm.DataObject);
            Preferences.Set("MigratorialInfo", json);
            Navigation.PopAsync();
        }

        private void cargaDatos()
        {
            var JsonStr = Preferences.Get("MigratorialInfo", "");
            if (string.IsNullOrWhiteSpace(JsonStr) == false)
            {
                var obj = JsonConvert.DeserializeObject<MigratorialInformation>(JsonStr);
                dataForm.DataObject = obj;
            }
        }
    }
}