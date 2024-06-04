using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab_mvp.Models
{
    internal class LoadState
    {
        public List<Event> LoadFromFile(string filename)
        {
            List<Event> events = new List<Event>();
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(List<Event>));
                events = (List<Event>)XML.Deserialize(stream);
            }
            return events;

        }
    }
}
