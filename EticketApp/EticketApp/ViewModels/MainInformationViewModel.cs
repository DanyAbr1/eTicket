using EticketApp.Services;
using EticketApp.ViewModels.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace EticketApp.ViewModels
{
    public class MainInformationViewModel : ViewModelBase
    {
        public ICommand GeneralInformationCommand
            => new Command<GeneralInformationViewModel>(GoGeneralInformation);

        public ICommand MigratorialInformationCommand
            => new Command<MingratorialInformationViewModel>(GoMigratorialInformation);


        public MainInformationViewModel()
        {

        }
        private async void GoGeneralInformation(GeneralInformationViewModel obj)
        {
            await NavigationService.Instance.NavigateToAsync<GeneralInformationViewModel>(obj);
        }

        private async void GoMigratorialInformation(MingratorialInformationViewModel obj)
        {
            await NavigationService.Instance.NavigateToAsync<MingratorialInformationViewModel>(obj);
        }
    }
}
