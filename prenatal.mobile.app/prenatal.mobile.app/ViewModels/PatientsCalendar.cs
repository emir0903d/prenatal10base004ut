using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamForms.Controls;

namespace prenatal.mobile.app.ViewModels
{
    public class PatientsCalendar: BindableObject
    {
        public int _currentPatientId { get; set; } = -1;

        public APIservice _users = new APIservice("User");
        public bool _showInfo { get; set; }
        public int? _myDocId { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }

        private APIservice _appointmentService = new APIservice("Appointment");
       
        public ICommand _detectEvents { get; set; }
        private void AddAllocateSpecialDate(ObservableCollection<SpecialDate> specials, DateTime date)
        {
            SpecialDate spec = new SpecialDate(date)
            {
                Selectable = true,
                BackgroundPattern = new BackgroundPattern(1)
                {
                    Pattern = new List<Pattern>
                    {
                        new Pattern { WidthPercent = 1f, HightPercent = 0.6f, Color = Color.Transparent },
                        new Pattern { WidthPercent = 1f, HightPercent = 0.4f, Color = Color.Transparent, Text = "*", TextColor = Color.Red, TextSize = 10, TextAlign = TextAlign.Middle }

                    }
                },
                BackgroundColor = Color.Transparent
            };
            specials.Add(spec);

        }
        private void ModifySpecialDate(DateTime date)
        {
            SpecialDate spec = new SpecialDate(date)
            {
                Selectable = true,
                BackgroundPattern = new BackgroundPattern(1)
                {
                    Pattern = new List<Pattern>
                    {
                        new Pattern { WidthPercent = 1f, HightPercent = 0.6f, Color = Color.Transparent },
                        new Pattern { WidthPercent = 1f, HightPercent = 0.4f, Color = Color.Transparent, Text = "*", TextColor = Color.Black, TextSize = 10, TextAlign = TextAlign.Middle }

                    }
                },
                BackgroundColor = Color.Transparent
            };
            SpecialDates.Add(spec);

        }
        public async Task DetectEvents()
        {
            APIservice.Username = _username;
            APIservice.Password = _password;
            
            User _patient = await _users.GetById<User>(_currentPatientId);
            _myDocId = _patient.DoctorId;

            SearchAppointmentRequest request = new SearchAppointmentRequest();
            request._docId = _myDocId;

            List<Appointment> _appoint = await _appointmentService.Get<List<Appointment>>(request);
            SpecialDates.Clear();

            ObservableCollection<SpecialDate> appointments = new ObservableCollection<SpecialDate>();
            if (_appoint != null)
            {
                foreach (Appointment a in _appoint)
                {
                    if (!SpecialDates.Select(a => a.Date).Contains(a.Date))
                    {
                        AddAllocateSpecialDate(appointments, a.Date);
                    }

                }
                SpecialDates = new ObservableCollection<SpecialDate>(appointments);
            }

        }

        public PatientsCalendar()
        {
            
            _detectEvents = new Command(async () => await DetectEvents());
        }

        private DateTime? _date;
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        private ObservableCollection<SpecialDate> _specialDates { get; set; } = new ObservableCollection<SpecialDate>();
        public ObservableCollection<SpecialDate> SpecialDates
        {
            get
            {
                return _specialDates;
            }
            set
            {
                _specialDates = value;
                OnPropertyChanged(nameof(SpecialDates));


            }
        }
        public Command DateChosen
        {
            get
            {
                return new Command(async (obj) =>
                {
                    //DateTime date = (DateTime)obj;
                    //if(TodayEvents.Where(x=>x.Date.Day != date.Day).Count()>0){
                    //    TodayEvents.Clear();
                    //}
                    TodayEvents.Clear();
                    await GenerateEventsForToday(obj as DateTime?);

                });
            }
        }
        public ObservableCollection<Appointment> TodayEvents { get; set; } = new ObservableCollection<Appointment>();
        public async Task GenerateEventsForToday(DateTime? _today)
        {
            APIservice.Username = _username;
            APIservice.Password = _password;
            SearchAppointmentRequest request = null;
            List<Appointment> appointments = null;
            List<Appointment> freeSlots = null;

            if (_today != null)
            {

                request = new SearchAppointmentRequest();
                request.date = _today;
                User _patient = await _users.GetById<User>(_currentPatientId);
                _myDocId = _patient.DoctorId;
                request._docId = _myDocId;            

                appointments = await _appointmentService.Get<List<Appointment>>(request);
                
                freeSlots = new List<Appointment>();
                for (int i = 8; i < 17; i++)
                {
                    freeSlots.Add(new Appointment() { Date = (DateTime)_today, Status = Appointment.SlotStatus.Free, Time = new DateTime(_today.Value.Year, _today.Value.Month, _today.Value.Day, i, 0, 0) });
                }
            }

            //Put all free slots in today events
            foreach(Appointment free in freeSlots)
            {
                TodayEvents.Add(free);
            }
            //If appointments are found -> 
            if (appointments != null && appointments.Count() > 0)
            {
                for(int a=0; a<appointments.Count(); a++)
                {
                    //Then check if appointment time coressponds with freeslot
                    if (TodayEvents.Select(t => t.Time).Any(tt => tt.Hour == appointments[a].Time.Hour))
                    {
                        for (int i = 0; i < TodayEvents.Count(); i++)
                        {
                            //If it does then replace it
                            if (TodayEvents[i].Time == appointments[a].Time)
                            {
                                TodayEvents[i] = appointments[a];
                            }
                        }
                    }
                }
                
            }

        }

    }
}
