using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class WindowsPhoneAppLink
    {
        [JsonProperty("app_id")]
        public string AppID;
        [JsonProperty("app_name")]
        public string AppName;
        public string Url;
    }
}
