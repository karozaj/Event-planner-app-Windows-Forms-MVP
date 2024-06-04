using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab_mvp.Models
{
    internal class SaveState
    {
        public void SaveToXMLFile(List<Event> events, string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Event>));
                XML.Serialize(stream, events);
            }

        }
    }
}
