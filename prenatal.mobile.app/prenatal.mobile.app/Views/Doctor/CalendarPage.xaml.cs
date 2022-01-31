using prenatal.mobile.app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prenatal.mobile.app.Views.Doctor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        public DoctorsCalendar Calendar = null;
        public CalendarPage(string _username, string _password, int _currentDoctorId)
        {
            InitializeComponent();
            Calendar = new DoctorsCalendar();
            Calendar._username = _username;
            Calendar._password = _password;
            Calendar._currentDoctorId = _currentDoctorId;
            Calendar._detectAppointments.Execute(null);
            BindingContext = Calendar;
   
        }
        private void Calendar_DateClicked(object sender, XamForms.Controls.DateTimeEventArgs e)
        {
            var x = new CalendarAppointment();
            //Calendar.TodayEvents.Clear();
            x.BindingContext = Calendar;
            x._currentDoctorId = Calendar._currentDoctorId;
            x._username = Calendar._username;
            x._password = Calendar._password;
            x.Parent = this;
            if (rootGrid.Children.Count() > 1)
            {
                rootGrid.Children.RemoveAt(1);
            }
            rootGrid.Children.AddVertical(x);

        }
        
    }
}