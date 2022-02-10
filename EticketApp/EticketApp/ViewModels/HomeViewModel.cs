using EticketApp.Services;
using EticketApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EticketApp.ViewModels
{
    public class HomeViewModel:ViewModelBase
    {
        public ICommand MainInformationCommand
            => new Command<MainInformationViewModel>(GoMainInformation);
        public HomeViewModel()
        {

        }

        private async void GoMainInformation(MainInformationViewModel obj)
        {
            await NavigationService.Instance.NavigateToAsync<MainInformationViewModel>(obj);
        }

     
    }
}
