using System.ComponentModel;
using Xamarin.Forms;

namespace MeuTemplate.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MainViewModel();
        }
    }
}
