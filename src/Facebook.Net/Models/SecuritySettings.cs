using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class SecuritySettings
    {
        [JsonProperty("secure_browsing")]
        public SecureBrowsing SecureBrowsing;
    }
}
