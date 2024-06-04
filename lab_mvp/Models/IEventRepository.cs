using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_mvp.Models
{
    public interface IEventRepository
    {
        void Add(Event e);
        IEnumerable<Event> GetAll();
        void Remove(Event e);
        void SetList(List<Event> list);
        void Sort(string PropertyName);
    }
}
