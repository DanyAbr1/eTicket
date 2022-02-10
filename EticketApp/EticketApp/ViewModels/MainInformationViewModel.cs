using EticketApp.Services;
using EticketApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EticketApp.ViewModels
{
    public class MainInformationViewModel:ViewModelBase
    {
        public ICommand GeneralInformationCommand 
            => new Command<GeneralInformationViewModel>(GoGeneralInformation);

        public MainInformationViewModel()
        {

        }
        private async void GoGeneralInformation(GeneralInformationViewModel obj)
        {
           await NavigationService.Instance.NavigateToAsync<GeneralInformationViewModel>(obj);
        }
    }
}
