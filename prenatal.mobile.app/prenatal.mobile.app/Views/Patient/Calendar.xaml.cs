using prenatal.mobile.app.ViewModels;
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
    public partial class Calendar : ContentPage
    {
        public PatientsCalendar _Calendar = null;
        public Calendar(string _username, string _password, int _currentPatientId)
        {
            InitializeComponent();
            _Calendar = new PatientsCalendar();
            _Calendar._username = _username;
            _Calendar._password = _password;

            _Calendar._currentPatientId = _currentPatientId;
            _Calendar._detectEvents.Execute(null);
            BindingContext = _Calendar;
        }

        private void xcalendar_DateClicked(object sender, XamForms.Controls.DateTimeEventArgs e)
        {
            var x = new CalendarEvents();
            
            x.BindingContext = _Calendar;
            x._currentPatientId = _Calendar._currentPatientId;
            x._username = _Calendar._username;
            x._password = _Calendar._password;
            x.Parent = this;
            
            if (rootGrid.Children.Count() > 0)
            {
                rootGrid.Children.Clear();
            }
            rootGrid.Children.Add(x);
        }
    }
}