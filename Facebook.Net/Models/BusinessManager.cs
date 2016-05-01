using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class BusinessManager
    {
        public string Name;
        [JsonProperty("timezone_id")]
        public int TimezoneID;
        [JsonProperty("primary_page")]
        public PrimaryPage PrimaryPage;
        public long ID;
        [JsonProperty("update_time")]
        public string UpdateTime;
        [JsonProperty("updated_by")]
        public ChangedBy UpdatedBy;
        [JsonProperty("creation_time")]
        public string CreationTime;
        [JsonProperty("created_by")]
        public ChangedBy CreatedBy;
    }
}
