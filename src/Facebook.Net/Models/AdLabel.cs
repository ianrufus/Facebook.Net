using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class AdLabel
    {
        public string ID;
        public string Account; // AdAccount object
        [JsonProperty("created_time")]
        public DateTime CreatedTime;
        public string Name;
        [JsonProperty("updated_time")]
        public DateTime UpdatedTime;
    }
}
