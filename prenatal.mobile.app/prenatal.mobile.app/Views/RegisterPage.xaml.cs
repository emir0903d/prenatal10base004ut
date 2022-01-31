using prenatal.mobile.app.ViewModels;
using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prenatal.mobile.app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        private readonly RegService _regService = new RegService();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            UserRegisterRequest x = new UserRegisterRequest();
            x.Name = EntName.Text;
            x.Surname = EntSurname.Text;
            x.Gender = EntGender.Text;
            x.Email = EntEmail.Text;
            x.PhoneNumber = EntPhoneNumber.Text;
            x.Registration = DateTime.Now;

            x.Type = (model.Enumerations.UserType.Type)PckType.SelectedItem;
            if (PckDoc.SelectedItem != null)
            {
                User doc = (User)PckDoc.SelectedItem;
                x.DoctorId = doc.Id;
            }
            var result = await _regService.Register(x);

            if(result != null)
            {
                await Application.Current.MainPage.DisplayAlert("Important!!!", "Please check your e-mail", "Ok!");
                App.Current.MainPage = new LoginPage();
            }
            

        }
    }
}