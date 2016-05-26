using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class ProjectExperience
    {
        public string ID;
        public string Description;
        [JsonProperty("end_date")]
        public string EndDate;
        public User From;
        public string Name;
        [JsonProperty("start_date")]
        public string StartDate;
        public List<User> With;
    }
}
