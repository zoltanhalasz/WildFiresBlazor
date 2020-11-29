using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WildFiresBlazor.Data
{
    public class Container
    {
        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("events")]
        public List<Event> events { get; set; }
    }

    public class Event
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
        [JsonProperty("categories")]
        public List<category> categories { get; set; }
        [JsonProperty("sources")]
        public List<source> sources { get; set; }
        [JsonProperty("geometries")]
        public List<geometry> geometries { get; set; }

    }

    public class category
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("title")]
        public string title
        {
            get; set;
        }
    }

    public class source
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("url")]
        public string url
        {
            get; set;
        }
    }

    public class geometry
    {
        [JsonProperty("date")]
        public string date { get; set; }
        [JsonProperty("type")]
        public string type
        {
            get; set;
        }
        [JsonProperty("coordinates")]
        public List<decimal> coordinates { get; set; }
    }


    public class FireMarker
    {
    
        public string date { get; set; }
        public string location { get; set; }
        public double x { get; set; }
        public double y { get; set; }

    }
}
