using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class IOSAppLink
    {
        [JsonProperty("app_name")]
        public string AppName;
        [JsonProperty("app_store_id")]
        public string AppStoreID;
        public string Url;
    }
}
