using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    // Change class name without breaking serialization
    public class FeedData
    {
        public string Story;
        [JsonProperty("created_time")]
        public string CreatedTime;
        public string ID;
        public string Message;
    }
}
