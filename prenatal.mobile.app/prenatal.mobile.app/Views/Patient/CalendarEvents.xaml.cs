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

namespace prenatal.mobile.app.Views.Patient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarEvents : ContentView
    {
        public int _currentPatientId { get; set; } = -1;
        public int? _myDocId { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        private APIservice _appointments = new APIservice("Appointment");
        private APIservice _users = new APIservice("User");

        public CalendarEvents()
        {
            
            InitializeComponent();
            APIservice.Username = _username;
            APIservice.Password = _password;

        }

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            User patient = await _users.GetById<User>(_currentPatientId);
            _myDocId = patient.DoctorId;

            var cell = sender as Cell;
            if (cell != null)
            {
                if (cell.FindByName<Label>("Status").Text == "Free")
                {
                    bool answer = await Application.Current.MainPage.DisplayAlert("Make appointment", "Would you like to make appointment?", "Yes", "No");
                    if (answer == true)
                    {
                        var _date_value = cell.FindByName<Label>("Date").Text;
                        var _date = DateTime.Parse(_date_value);

                        var _time_value = cell.FindByName<Label>("Time").Text;
                        var _time = DateTime.Parse(_time_value);

                        AppointmentUpsertRequest request = new AppointmentUpsertRequest();
                        request.Date = _date;
                        var _exact_time = new DateTime(_date.Year, _date.Month, _date.Day, _time.Hour, _time.Minute, _time.Second);
                        
                        request.Time = _exact_time;

                        request.Status = Appointment.SlotStatus.Reserved;

                        request.PatientId = _currentPatientId;
                        request.DoctorId = (int)_myDocId;

                        var a = await _appointments.Insert<Appointment>(request);

                        var c = this.Parent.Parent.BindingContext as PatientsCalendar;
                        c.TodayEvents.Clear();
                        c.SpecialDates.Clear();
                        await c.DetectEvents();
                        await c.GenerateEventsForToday(a.Date.Date);
                        this.Parent.Parent.BindingContext = c;
                    }
                }

            }
        }
    }
    }