using System;
using System.Collections.Generic;
using prenatal.mobile.app.ViewModels;
using prenatal.mobile.app.Views;
using prenatal.mobile.app.Views.Admin;
using Xamarin.Forms;

namespace prenatal.mobile.app
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            //Routing.RegisterRoute(nameof(AdminPage), typeof(AdminPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
