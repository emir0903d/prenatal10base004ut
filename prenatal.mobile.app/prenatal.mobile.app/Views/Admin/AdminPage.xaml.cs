using prenatal.mobile.app.ViewModels;
using prenatal.model;
using prenatal.model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prenatal.mobile.app.Views.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPage : ContentPage
    {
        Admins UsersList = null;
        protected readonly APIservice _users = new APIservice("User");
        public AdminPage(string _username, string _password)
        {
            InitializeComponent();
            UsersList = new Admins();
            UsersList._username = _username;
            UsersList._password = _password;
            BindingContext = UsersList;
            APIservice.Username = _username;
            APIservice.Password = _password;

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await UsersList.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            User tappedUser = e.Item as User;
            if (tappedUser.Status == UserStatus.Status.None || tappedUser.Status == UserStatus.Status.Approved)
            {
                tappedUser.Status = UserStatus.Status.Rejected;
            }
            else
            {
                tappedUser.Status = UserStatus.Status.Approved;
            }

            await _users.Update<User>(tappedUser.Id, tappedUser);
            // Application.Current.MainPage = new NavigationPage(new AdminPage(UsersList._username, UsersList._password));

            Application.Current.MainPage = new AdminPage(UsersList._username, UsersList._password);

        }



        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedUser = e.SelectedItem as User;
        }
    }
}