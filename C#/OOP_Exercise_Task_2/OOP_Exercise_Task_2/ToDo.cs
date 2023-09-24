using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Task_2
{
    internal class ToDo
    {
        private string _topic;
        private string _assinged;
        private string _note;
        private DateTime _dateTime;
        private bool _done;

        public ToDo(string topic, string assinged, string note, DateTime dateTime, bool done) { 
            _topic = topic;
            _assinged = assinged;
            _note = note;
            _dateTime = dateTime;
            _done = done;
        }

        public string Topic
        {
            get => _topic;
            set => _topic = value;
        }

        public string Assinged
        {
            get => _assinged;
            set => _assinged = value;
        }

        public string Note
        {
            get => _note;
            set => _note = value;
        }

        public DateTime DateTime
        {
            get => _dateTime;
            set => _dateTime = value;
        }

        public bool Done
        {
            get => _done; 
            set => _done = value;
        }
    }
}
