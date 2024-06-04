using lab_mvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_mvp.Repositories
{
    public class EventRepository : IEventRepository
    {
        private List<Event> _events;

        public EventRepository()
        {
            _events = new List<Event>();
        }

        public void Add(Event e)
        {
            _events.Add(e);
        }

        public void Remove(Event e)
        {
            _events.Remove(e);
        }

        public IEnumerable<Event> GetAll()
        {
            var eventList = new List<Event>();
            foreach (var e in _events)
            {
                //if(e.Priority==0)
                eventList.Add(e);
            }

            return eventList;
        }

        public void SetList(List<Event> list)
        {
            _events = list;
        }

        public void Sort(string PropertyName)
        {
            if (PropertyName == "Typ")
                _events = _events.OrderBy(e => e.Type).ToList();
            else if (PropertyName == "Priorytet")
                _events = _events.OrderBy(e => e.Priority).ToList();
            else if (PropertyName == "Data")
                _events = _events.OrderBy(e => e.Date).ToList();
            else
                return;
        }
    }
}
