using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MeuTemplate.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ProfileViewModel();
        }
    }
}
