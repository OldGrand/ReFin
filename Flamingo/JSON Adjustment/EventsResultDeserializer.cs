using Flamingo.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Flamingo.JSON_Adjustment
{
    class EventsResultDeserializer
    {
        EventsRootObject _eventsRootObject;
        string _fileName;

        public EventsResultDeserializer(string fileNameWithoutExtension)
        {
            _fileName = $"{fileNameWithoutExtension}.json";
            _eventsRootObject = new EventsRootObject(); 
        }

        public EventsRootObject StartDeserializing()
        {
            using (FileStream sw = new FileStream(_fileName, FileMode.Open))
            {
                sw.Position = 0;
                _eventsRootObject = new DataContractJsonSerializer(typeof(EventsRootObject)).ReadObject(sw) as EventsRootObject;
            }
            return _eventsRootObject;
        }
    }
}
