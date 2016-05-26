using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Place
    {
        public string ID;
        public Location Location;
        public string Name;
        [JsonProperty("overall_rating")]
        public float OverallRating;
    }
}
