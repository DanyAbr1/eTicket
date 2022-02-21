using System;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EticketApp.Views
{
    public partial class GenereateQrView : Popup
    {
        public GenereateQrView()
        {
            InitializeComponent();
            var json = Preferences.Get("MigratorialInfo", "");
            qrtxt.BarcodeValue = json;

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {            
            Dismiss(null);
        }

    }
}