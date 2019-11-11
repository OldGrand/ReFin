using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Flamingo.Classes
{
    [DataContract]
    public class EventsRootObject
    {
        [DataMember(Order = 0)]
        public int count { get; set; }
        [DataMember(Order = 1)]
        public bool overflow { get; set; }
        [DataMember(Order = 2)]
        public string next { get; set; }
        [DataMember(Order = 3)]
        public object previous { get; set; }
        [DataMember(Order = 4)]
        public List<Result> results { get; set; }

        [DataContract]
        public class Entity
        {
            [DataMember(Order = 0)]
            public string formatted_address { get; set; }
            [DataMember(Order = 1)]
            public string entity_id { get; set; }
            [DataMember(Order = 2)]
            public string type { get; set; }
            [DataMember(Order = 3)]
            public string name { get; set; }

            public override string ToString()
            {
                return $"Адрес: {formatted_address}{Environment.NewLine}Заведение: {name}{Environment.NewLine}";
            }
        }
        [DataContract]
        public class Result
        {
            [DataMember(Order = 0)]
            public object relevance { get; set; }
            [DataMember(Order = 1)]
            public string id { get; set; }
            [DataMember(Order = 2)]
            public string title { get; set; }
            [DataMember(Order = 3)]
            public string description { get; set; }
            [DataMember(Order = 4)]
            public string category { get; set; }
            [DataMember(Order = 5)]
            public List<string> labels { get; set; }
            [DataMember(Order = 6)]
            public int rank { get; set; }
            [DataMember(Order = 7)]
            public int local_rank { get; set; }
            [DataMember(Order = 8)]
            public List<Entity> entities { get; set; }
            [DataMember(Order = 9)]
            public int duration { get; set; }
            [DataMember(Order = 10)]
            public string start { get; set; }
            [DataMember(Order = 1)]
            public string end { get; set; }
            [DataMember(Order = 12)]
            public string updated { get; set; }
            [DataMember(Order = 13)]
            public string first_seen { get; set; }
            [DataMember(Order = 14)]
            public string timezone { get; set; }
            [DataMember(Order = 15)]
            public List<double> location { get; set; }
            [DataMember(Order = 16)]
            public string scope { get; set; }
            [DataMember(Order = 17)]
            public string country { get; set; }
            [DataMember(Order = 18)]
            public List<List<string>> place_hierarchies { get; set; }
            [DataMember(Order = 19)]
            public string state { get; set; }

            public override string ToString()
            {
                return $"Название: {title}{Environment.NewLine}Описание: {description}{Environment.NewLine}Категория: {category}{Environment.NewLine}Начало: {start}{Environment.NewLine}Завершение: {end}{Environment.NewLine}Масштаб: {scope}{Environment.NewLine}Ранг: {rank}{Environment.NewLine}Локальный ранг {local_rank}{Environment.NewLine}Доп. сведения: {Environment.NewLine}{((entities.Count > 0) ? entities.First().ToString() : "-")}{Environment.NewLine}";
            }
        }
    }
}
