using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class CoverPhoto
    {
        public string ID;
        // Facebook Graph API Docs have cover_id marked as deprecated - use id instead
        [JsonProperty("cover_id")]
        public string CoverID;
        [JsonProperty("offset_x")]
        public float OffsetX;
        [JsonProperty("offset_y")]
        public float OffsetY;
        public string Source;
    }
}
