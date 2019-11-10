using System.IO;
using System.Runtime.Serialization.Json;

namespace Flamingo.Classes
{
    class SearchResultDeserializer
    {
        RootObject _rootObject;
        string _fileName;
        public SearchResultDeserializer(string fileNameWithoutExtension)
        {
            _fileName = $"{fileNameWithoutExtension}.json";
            _rootObject = new RootObject();
        }

        public RootObject StartDeserializing()
        {
            using (FileStream sw = new FileStream(_fileName, FileMode.Open))
            {
                sw.Position = 0;
                _rootObject = new DataContractJsonSerializer(typeof(RootObject)).ReadObject(sw) as RootObject;
            }
            return _rootObject;
        }
    }
}
