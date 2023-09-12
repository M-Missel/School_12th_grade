using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_Appointment
{
    internal class Appointment
    {
        private string _topic;
        private DateTime _date;
        private DateTime _time;
        private string _location;
        private bool _repeat;
        private bool _reminder;
        private DateTime _reminderDate;

        Appointment(string topic, DateTime date, DateTime time, string location) { 
            _topic = topic;
            _date = date;
            _time = time;
            _location = location;
        }

        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public bool Repeat
        {
            get { return _repeat; }
            set { _repeat = value; }
        }

        public bool Reminder
        {
            get { return _reminder; }
            set { _reminder = value; }
        }

        public DateTime ReminderDate
        {
            get { return _reminderDate; }
            set { _reminderDate = value; }
        }
    }
}
