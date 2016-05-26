using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class WebAppLink
    {
        [JsonProperty("should_fallback")]
        public bool? ShouldFallback;
        public string Url;
    }
}
