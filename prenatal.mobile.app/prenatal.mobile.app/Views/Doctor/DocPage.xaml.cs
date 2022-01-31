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
    public partial class DocPage : TabbedPage
    {
        public int _currentUserId { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }

        public DocPage(string _user, string _pass, int _id)
        {
            
            Children.Add(new DoctorPatients(_user, _pass, _id) {Title="Patients" });
            Children.Add(new CalendarPage(_user, _pass, _id) {Title="Calendar" });
            InitializeComponent();

        }
    }
}