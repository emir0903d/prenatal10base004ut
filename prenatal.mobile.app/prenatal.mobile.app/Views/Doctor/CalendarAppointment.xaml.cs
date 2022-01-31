using prenatal.mobile.app.ViewModels;
using prenatal.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prenatal.mobile.app.Views.Doctor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarAppointment : ContentView
    {
        public int _currentDoctorId { get; set; } = -1;
        public string _username { get; set; }
        public string _password { get; set; }
        private APIservice _appointments = new APIservice("Appointment");
        public CalendarAppointment()
        {
            InitializeComponent();
            APIservice.Username = _username;
            APIservice.Password = _password;

        }

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            
            var cell = sender as Cell;
            if (cell != null)
            {
                if (cell.FindByName<Label>("Status").Text == "Reserved")
                {
                    bool answer = await Application.Current.MainPage.DisplayAlert("Cancel appointment", "Would you like to cancel this appointment?", "Yes", "No");
                    if (answer == true)
                    {
                        if (cell.FindByName<Label>("Id").Text == "") return;

                        int Id = Int32.Parse(cell.FindByName<Label>("Id").Text);
                        var a = await _appointments.Delete<Appointment>(Id);
                        var c = this.Parent.Parent.BindingContext as DoctorsCalendar;
                        c.TodayEvents.Clear();
                        c.SpecialDates.Clear();
                        await c.DetectAppointments();
                        await c.GenerateAppointments(a.Date.Date);
                        this.Parent.Parent.BindingContext = c;

                    }
                }
            }
        }
    }
}