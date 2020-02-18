using System.Windows.Input;
using MeuTemplate.Views;
using Xamarin.Forms;

namespace MeuTemplate.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand ProfileCommand { get; private set; }

        public MainViewModel()
        {
            Title = "Main";
            ProfileCommand = new Command(ExecuteProfileCommand);
        }

        private async void ExecuteProfileCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ProfilePage());
        }
    }
}
