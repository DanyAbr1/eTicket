using System;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace EticketApp.Views
{
    public partial class GenereateQrView : Popup
    {
        public GenereateQrView()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {            
            Dismiss(null);
        }

    }
}