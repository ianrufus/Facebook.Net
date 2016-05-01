using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Group
    {
        public string ID;
        public CoverPhoto Cover;
        public string Description;
        public string Email;
        public string Icon;
        [JsonProperty("member_request_count")]
        public int MemberRequestCount;
        public string Name;
        public object Owner; // Page or User - can be either.
        public object Parent; // Group, Page or App
        public string Privacy;
        [JsonProperty("updated_time")]
        public DateTime UpdatedTime;
    }
}
