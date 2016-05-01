using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Location
    {
        public string City;
        public string Country;
        public float Latitude;
        [JsonProperty("located_in")]
        public string LocatedIn;
        public float Longitude;
        public string Name;
        public string Region;
        public string State;
        public string Street;
        public string Zip;
    }
}
