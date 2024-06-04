using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace lab_mvp.Models
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int Priority { get; set; } //0-low 1-medium 2-high
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Date}, {Type}, {Priority}, {Description}";
        }
        
        public Event(string name, DateTime date, string type, int priority, string description)
        {
            Name = name;
            Date = date;
            Type = type;
            Priority = priority;
            Description = description;
        }

        public Event(Event e)
        {
            Name = e.Name;
            Date = e.Date;
            Type = e.Type;
            Priority = e.Priority;
            Description = e.Description;
        }

        public Event()
        {

        }

    }
}
