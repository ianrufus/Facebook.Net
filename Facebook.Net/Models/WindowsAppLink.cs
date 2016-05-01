using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class WindowsAppLink
    {
        [JsonProperty("app_id")]
        public string AppID;
        [JsonProperty("app_name")]
        public string AppName;
        [JsonProperty("package_family_name")]
        public string PackageFamilyName;
        public string Url;
    }
}
