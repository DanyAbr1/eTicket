using System.Threading.Tasks;
using Xamarin.Forms;

namespace EticketApp.ViewModels.Base
{
    public class ViewModelBase : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
