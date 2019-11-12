using Flamingo.API;
using System.IO;
using System.Net;

namespace Flamingo.Classes
{
    class YandexAPI
    {
        private string _organization;
        private string _city;
        private string _advancedSearchOptions;
        private string _fileName;

        public YandexAPI(string organization, string city, string fileNameWithoutExtension)
        {
            YandexTranslator yandexTranslator = new YandexTranslator();
            _organization = yandexTranslator.Translate(organization);
            _city = yandexTranslator.Translate(city);
            _fileName = $"{fileNameWithoutExtension}.json";
            _advancedSearchOptions = "";
        }

        public YandexAPI(string organization, string city, string advancedSearchOptions, string fileToSave) : this(organization, city, fileToSave)
        {
            _advancedSearchOptions = $", {advancedSearchOptions}";
        }

        public void StartSearch()
        {
            string url = @"https://search-maps.yandex.ru/v1/?text=" + $"{_organization}, {_city}{_advancedSearchOptions}&type=biz&lang=en_US&results=10&apikey=153db2c3-2713-40f0-8213-e8f61917292d";

            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            Stream data = response.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            string responseFromServer = reader.ReadToEnd();

            response.Close();

            File.WriteAllText(_fileName, responseFromServer);
        }
    }
}
