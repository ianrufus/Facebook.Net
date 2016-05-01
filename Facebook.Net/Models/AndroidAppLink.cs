using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class AndroidAppLink
    {
        [JsonProperty("app_name")]
        public string AppName;
        public string Class;
        public string Package;
        public string Url;
    }
}
